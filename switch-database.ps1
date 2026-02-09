# Database Context Switching Script
# This script makes it easy to switch between production and development databases

param(
    [string]$Environment = "",
    [switch]$Status,
    [switch]$Help
)

function Show-Help {
    Write-Host "=== Database Context Switching ===" -ForegroundColor Green
    Write-Host ""
    Write-Host "Usage:" -ForegroundColor Yellow
    Write-Host "  .\switch-database.ps1 dev        # Switch to development database" -ForegroundColor White
    Write-Host "  .\switch-database.ps1 prod       # Switch to production database" -ForegroundColor White
    Write-Host "  .\switch-database.ps1 -Status    # Show current database setting" -ForegroundColor White
    Write-Host "  .\switch-database.ps1 -Help      # Show this help" -ForegroundColor White
    Write-Host ""
    Write-Host "Databases:" -ForegroundColor Yellow
    Write-Host "  Production:  mt-sql-server-basic (Azure SQL Basic)" -ForegroundColor White
    Write-Host "  Development: sky-web-api-dev (Azure SQL Serverless)" -ForegroundColor White
    Write-Host ""
}

function Show-Status {
    Write-Host "=== Current Database Configuration ===" -ForegroundColor Green
    
    $useDevDb = $env:USE_DEV_DATABASE
    $useProdDb = $env:USE_PROD_DATABASE
    
    Write-Host ""
    Write-Host "Environment Variables:" -ForegroundColor Yellow
    Write-Host "  USE_DEV_DATABASE:  $($useDevDb ?? 'not set')" -ForegroundColor White
    Write-Host "  USE_PROD_DATABASE: $($useProdDb ?? 'not set')" -ForegroundColor White
    Write-Host "  ASPNETCORE_ENVIRONMENT: $($env:ASPNETCORE_ENVIRONMENT ?? 'not set')" -ForegroundColor White
    
    Write-Host ""
    Write-Host "Active Database:" -ForegroundColor Yellow
    if ($useDevDb -eq "true" -or ($env:ASPNETCORE_ENVIRONMENT -eq "Development" -and $useProdDb -ne "true")) {
        Write-Host "  🟢 DEVELOPMENT (sky-web-api-dev)" -ForegroundColor Green
    } else {
        Write-Host "  🔴 PRODUCTION (mt-sql-server-basic)" -ForegroundColor Red
    }
    Write-Host ""
}

if ($Help) {
    Show-Help
    exit 0
}

if ($Status) {
    Show-Status
    exit 0
}

if ($Environment -eq "") {
    Show-Help
    exit 0
}

Write-Host "=== Database Context Switching ===" -ForegroundColor Green

switch ($Environment.ToLower()) {
    "dev" {
        Write-Host ""
        Write-Host "🔄 Switching to DEVELOPMENT database..." -ForegroundColor Yellow
        $env:USE_DEV_DATABASE = "true"
        $env:USE_PROD_DATABASE = $null
        $env:ASPNETCORE_ENVIRONMENT = "Development"
        Write-Host "✅ Switched to DEVELOPMENT database (sky-web-api-dev)" -ForegroundColor Green
        Write-Host ""
        Write-Host "📋 Environment Variables Set:" -ForegroundColor Cyan
        Write-Host "  USE_DEV_DATABASE = true" -ForegroundColor White
        Write-Host "  ASPNETCORE_ENVIRONMENT = Development" -ForegroundColor White
        Write-Host ""
        Write-Host "🚀 Ready to run: dotnet run" -ForegroundColor Yellow
    }
    "prod" {
        Write-Host ""
        Write-Host "🔄 Switching to PRODUCTION database..." -ForegroundColor Yellow
        $env:USE_DEV_DATABASE = $null
        $env:USE_PROD_DATABASE = "true"
        $env:ASPNETCORE_ENVIRONMENT = "Production"
        Write-Host "⚠️  Switched to PRODUCTION database (mt-sql-server-basic)" -ForegroundColor Red
        Write-Host ""
        Write-Host "📋 Environment Variables Set:" -ForegroundColor Cyan
        Write-Host "  USE_PROD_DATABASE = true" -ForegroundColor White
        Write-Host "  ASPNETCORE_ENVIRONMENT = Production" -ForegroundColor White
        Write-Host ""
        Write-Host "⚠️  WARNING: You are now connected to PRODUCTION data!" -ForegroundColor Red
        Write-Host "🚀 Ready to run: dotnet run" -ForegroundColor Yellow
    }
    default {
        Write-Host ""
        Write-Error "Invalid environment: $Environment"
        Write-Host ""
        Write-Host "Valid options: 'dev', 'prod'" -ForegroundColor Yellow
        Show-Help
        exit 1
    }
}

Write-Host ""
Write-Host "💡 Tip: Run '.\switch-database.ps1 -Status' to check current configuration" -ForegroundColor Gray