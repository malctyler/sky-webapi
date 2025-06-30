# Get the Azure app settings
$resourceId = "/subscriptions/34db2036-2044-4833-b3e1-394f18589d31/resourceGroups/app-service-rg/providers/Microsoft.Web/sites/sky-webapi"
$appConfigName = "mt-core-appconfig"
$appConfigResourceGroup = "mt-core-services-rg"
$appConfigEndpoint = "https://mt-core-appconfig.azconfig.io"

# detrmine resource group and app name from resourceId
if ($resourceId -match "/resourceGroups/([^/]+)/providers/Microsoft.Web/sites/([^/]+)") {
    $resourceGroup = $matches[1]
    $appName = $matches[2]
}
else {
    Write-Host "Resource ID format is incorrect." -ForegroundColor Red
    exit 1
}

$azureSettings = (az webapp config appsettings list --resource-group $resourceGroup --name $appName | ConvertFrom-Json)
$azureConnectionStrings = (az webapp config connection-string list --resource-group $resourceGroup --name $appName | ConvertFrom-Json)

# Get App Configuration settings
Write-Host "Retrieving App Configuration settings..." -ForegroundColor Cyan
$appConfigSettings = @{}
try {
    $configList = az appconfig kv list --name $appConfigName --auth-mode login --query "[].{key:key, value:value, label:label}" -o json | ConvertFrom-Json
    foreach ($config in $configList) {
        if ($config.key) {
            $fullKey = if ($config.label) { "$($config.label):$($config.key)" } else { $config.key }
            $appConfigSettings[$fullKey] = $config.value
        }
    }
    Write-Host "Retrieved $($appConfigSettings.Count) settings from App Configuration" -ForegroundColor Green
} catch {
    Write-Host "Warning: Could not retrieve App Configuration settings." -ForegroundColor Yellow
    Write-Host "Note: You need 'App Configuration Data Reader' role for read access" -ForegroundColor Yellow
}

# Clean up any malformed connection strings
$malformedConnString = $azureConnectionStrings | Where-Object { $_.name -like "{*" }
if ($malformedConnString) {
    Write-Host "`nFound malformed connection string entry. Removing..." -ForegroundColor Yellow
    $result = az webapp config connection-string delete --resource-group $resourceGroup --name $appName --setting-names $malformedConnString.name
    if ($?) {
        Write-Host "Removed malformed connection string successfully!" -ForegroundColor Green
        # Refresh the connection strings list
        $azureConnectionStrings = (az webapp config connection-string list --resource-group $resourceGroup --name $appName | ConvertFrom-Json)
    }
}

# Read local JSON file
$localSettings = Get-Content -Path "D:\workingrepos\TheTylers\envsettings.json" | ConvertFrom-Json

# Create a lookup table for Azure settings
$azureLookup = @{}
foreach ($setting in $azureSettings) {
    # Convert Azure key format from "Something__Key" back to "Something:Key"
    $originalKey = $setting.name -replace '__', ':'
    $azureLookup[$originalKey] = $setting.value
}

Write-Host "`nComparing local settings with Azure and App Configuration...`n" -ForegroundColor Cyan

$settingsToUpdate = @()
$connectionStringsToUpdate = @()
$appConfigSettingsToUpdate = @()

# Compare settings
foreach ($setting in $localSettings) {
    # If the local setting is not a connection string, check it against Azure app settings
    if ($setting.Key -like "ConnectionStrings:*") {
        # Extract just the connection string name without the "ConnectionStrings:" prefix
        $connectionStringName = $setting.Key.Split(':')[1]
        $azureConnection = $azureConnectionStrings | Where-Object { $_.name -eq $connectionStringName }
        
        if ($azureConnection) {
            # Normalize connection strings by removing any trailing semicolons and ensuring spaces after semicolons
            $normalizedLocal = $setting.Value.TrimEnd(';') -replace ';(?! )', '; '
            $normalizedAzure = $azureConnection.value.TrimEnd(';') -replace ';(?! )', '; '
            
            if ($normalizedAzure -eq $normalizedLocal) {
                Write-Host "Connection string '$connectionStringName' exists in Azure with matching value" -ForegroundColor Green
            } else {
                Write-Host "Connection string '$connectionStringName' exists in Azure but values differ:" -ForegroundColor Yellow
                Write-Host "Local: $($setting.Value)" -ForegroundColor Yellow
                Write-Host "Azure: $($azureConnection.value)" -ForegroundColor Yellow
                $connectionStringsToUpdate += @{
                    name = $connectionStringName
                    value = $setting.Value
                    type = "SQLAzure"
                }
            }
        } else {
            Write-Host "Connection string '$connectionStringName' does not exist in Azure" -ForegroundColor Red
            $connectionStringsToUpdate += @{
                name = $connectionStringName
                value = $setting.Value
                type = "SQLAzure"
            }
        }
    }
    else {
        $key = $setting.Key
        $value = $setting.Value
        $isKeyVaultEnabled = $setting.keyvaultenabled -eq $true
    
        # Convert key format to Azure style
        $azureKey = $key -replace ':', '__'
        
        if ($isKeyVaultEnabled) {
            # For Key Vault enabled settings, check Azure App Settings
            if ($azureLookup.ContainsKey($key)) {
                if ($azureLookup[$key] -eq $value) {
                    Write-Host "Setting '$key' exists in Azure with matching value (Key Vault enabled)" -ForegroundColor Green
                } else {
                    Write-Host "Setting '$key' exists in Azure but values differ (Key Vault enabled):" -ForegroundColor Yellow
                    Write-Host "Local: $value" -ForegroundColor Yellow
                    Write-Host "Azure: $($azureLookup[$key])" -ForegroundColor Yellow
                    $settingsToUpdate += "$azureKey=$value"
                }
            } else {
                Write-Host "Setting '$key' does not exist in Azure (Key Vault enabled)" -ForegroundColor Red
                $settingsToUpdate += "$azureKey=$value"
            }
        } else {
            # For non-Key Vault settings, check App Configuration first
            if ($appConfigSettings.ContainsKey($key)) {
                if ($appConfigSettings[$key] -eq $value) {
                    Write-Host "Setting '$key' exists in App Configuration with matching value" -ForegroundColor Green
                } else {
                    Write-Host "Setting '$key' exists in App Configuration but values differ:" -ForegroundColor Yellow
                    Write-Host "  Local: $value" -ForegroundColor Yellow
                    Write-Host "  App Config: $($appConfigSettings[$key])" -ForegroundColor Yellow
                    # Parse key into label and setting name
                    $parts = $key.Split(':')
                    $appConfigSettingsToUpdate += @{
                        label = $parts[0]
                        key = $parts[1]
                        value = $value
                    }
                }
            } elseif ($azureLookup.ContainsKey($key)) {
                # Setting exists in Azure, suggest migration to App Configuration
                Write-Host "Setting '$key' exists in Azure App Settings (consider migrating to App Configuration)" -ForegroundColor Cyan
                Write-Host "Value: $($azureLookup[$key])" -ForegroundColor Cyan
            } else {
                Write-Host "Setting '$key' does not exist in App Configuration or Azure" -ForegroundColor Red
                # Parse key into label and setting name
                $parts = $key.Split(':')
                $appConfigSettingsToUpdate += @{
                    label = $parts[0]
                    key = $parts[1]
                    value = $value
                }
            }
        }
    }
}

if ($settingsToUpdate.Count -eq 0 -and $connectionStringsToUpdate.Count -eq 0 -and $appConfigSettingsToUpdate.Count -eq 0) {
    Write-Host "`nAll settings are in sync! No updates needed." -ForegroundColor Green
}
else {
    Write-Host "`nThe following changes will be made:" -ForegroundColor Cyan
    
    if ($settingsToUpdate.Count -gt 0) {
        Write-Host "`nApp Settings to update:" -ForegroundColor Yellow
        $settingsToUpdate | ForEach-Object {
            Write-Host "  $_"
        }
    }
    
    if ($connectionStringsToUpdate.Count -gt 0) {
        Write-Host "`nConnection Strings to update:" -ForegroundColor Yellow
        $connectionStringsToUpdate | ForEach-Object {
            Write-Host "  $($_.name) = $($_.value)"
        }
    }
    
    if ($appConfigSettingsToUpdate.Count -gt 0) {
        Write-Host "`nApp Configuration Settings to add:" -ForegroundColor Yellow
        $appConfigSettingsToUpdate | ForEach-Object {
            Write-Host "  $($_.key) (label: $($_.label)) = $($_.value)"
        }
    }
    
    $confirmation = Read-Host "`nDo you want to update these settings in Azure and App Configuration? (y/n)"
    if ($confirmation -eq 'y') {
        if ($settingsToUpdate.Count -gt 0) {
            Write-Host "`nUpdating App Settings..." -ForegroundColor Cyan
            # Join the settings with spaces for the Azure CLI command
            $settingsString = $settingsToUpdate -join " "
            $result = az webapp config appsettings set --resource-group $resourceGroup --name $appName --settings $settingsString
            if ($?) {
                Write-Host "App Settings updated successfully!" -ForegroundColor Green
            }
            else {
                Write-Host "Failed to update App Settings" -ForegroundColor Red
            }
        }
        
        if ($connectionStringsToUpdate.Count -gt 0) {
            Write-Host "`nUpdating Connection Strings..." -ForegroundColor Cyan
            # Create a settings string for connection strings
            $connectionStringsArgs = $connectionStringsToUpdate | ForEach-Object { 
                "$($_.name)=""$($_.value)"""
            }
            $result = az webapp config connection-string set --resource-group $resourceGroup --name $appName --connection-string-type SQLAzure --settings $connectionStringsArgs
            if ($?) {
                Write-Host "Connection Strings updated successfully!" -ForegroundColor Green
            }
            else {
                Write-Host "Failed to update Connection Strings" -ForegroundColor Red
            }
        }
        
        if ($appConfigSettingsToUpdate.Count -gt 0) {
            Write-Host "`nUpdating App Configuration Settings..." -ForegroundColor Cyan
            $successCount = 0
            $failCount = 0
            
            foreach ($configSetting in $appConfigSettingsToUpdate) {
                try {
                    Write-Host "  Adding: $($configSetting.key) with label '$($configSetting.label)'" -ForegroundColor Gray
                    
                    $result = az appconfig kv set --name $appConfigName --key $configSetting.key --value $configSetting.value --label $configSetting.label --auth-mode login --yes
                    if ($LASTEXITCODE -eq 0) {
                        $successCount++
                        Write-Host "Successfully added: $($configSetting.key)" -ForegroundColor Green
                    } else {
                        $failCount++
                        Write-Host "Failed to add: $($configSetting.key)" -ForegroundColor Red
                    }
                } catch {
                    $failCount++
                    Write-Host "Error adding $($configSetting.key): $($_.Exception.Message)" -ForegroundColor Red
                }
            }
            
            if ($successCount -gt 0) {
                Write-Host "Successfully added $successCount settings to App Configuration!" -ForegroundColor Green
            }
            if ($failCount -gt 0) {
                Write-Host "Failed to add $failCount settings to App Configuration" -ForegroundColor Red
                Write-Host "Note: You need 'App Configuration Data Owner' role for write access" -ForegroundColor Yellow
            }
        }
    }
    else {
        Write-Host "`nUpdate cancelled." -ForegroundColor Yellow
    }
}

Write-Host "`nProcess complete!" -ForegroundColor Cyan
