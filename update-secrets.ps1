# Read the local JSON file
$localSettings = Get-Content -Path "D:\workingrepos\TheTylers\sky-webapi\envsettings.json" | ConvertFrom-Json

# Get all current secrets and create a lookup table
$currentSecrets = @{}
dotnet user-secrets list | ForEach-Object {
    if ($_ -match "^(.+?)\s+=\s+(.*)$") {
        $currentSecrets[$matches[1]] = $matches[2]
    }
}

Write-Host "`nComparing local settings with User Secrets...`n" -ForegroundColor Cyan

$secretsToUpdate = @()

foreach ($setting in $localSettings) {
    $key = $setting.Key
    $value = $setting.Value

    if ($currentSecrets.ContainsKey($key)) {
        if ($currentSecrets[$key] -eq $value) {
            Write-Host "✓ Secret '$key' exists with matching value" -ForegroundColor Green
        } else {
            Write-Host "⚠ Secret '$key' exists but values differ:" -ForegroundColor Yellow
            Write-Host "  Local: $value" -ForegroundColor Yellow
            Write-Host "  Secret: $($currentSecrets[$key])" -ForegroundColor Yellow
            $secretsToUpdate += @{
                key = $key
                value = $value
            }
        }
    } else {
        Write-Host "✕ Secret '$key' does not exist in User Secrets" -ForegroundColor Red
        $secretsToUpdate += @{
            key = $key
            value = $value
        }
    }
}

if ($secretsToUpdate.Count -eq 0) {
    Write-Host "`nAll secrets are in sync! No updates needed." -ForegroundColor Green
}
else {
    Write-Host "`nThe following secrets will be updated:" -ForegroundColor Cyan
    $secretsToUpdate | ForEach-Object {
        Write-Host "  $($_.key)" -ForegroundColor Yellow
    }
    
    $confirmation = Read-Host "`nDo you want to update these secrets? (y/n)"
    if ($confirmation -eq 'y') {
        Write-Host "`nUpdating User Secrets..." -ForegroundColor Cyan
        foreach ($secret in $secretsToUpdate) {
            try {
                dotnet user-secrets set "$($secret.key)" "$($secret.value)"
                Write-Host "✓ Updated secret: $($secret.key)" -ForegroundColor Green
            }
            catch {
                Write-Host "✕ Failed to update secret: $($secret.key)" -ForegroundColor Red
                Write-Host "  Error: $_" -ForegroundColor Red
            }
        }
    }
    else {
        Write-Host "`nUpdate cancelled." -ForegroundColor Yellow
    }
}

Write-Host "`nProcess complete!" -ForegroundColor Cyan