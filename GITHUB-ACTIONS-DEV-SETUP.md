# GitHub Actions Development Workflow Setup - Complete

## ✅ Successfully Created

### 1. DEV Branch
- **Created**: `dev` branch from current `main` 
- **Pushed**: To GitHub repository (`origin/dev`)
- **Tracking**: Set up for future pushes

### 2. Development GitHub Actions Workflow
- **File**: `.github/workflows/dev_sky-webapi-dev.yml`
- **Trigger**: Pushes to `dev` branch + manual workflow dispatch
- **Target**: `sky-webapi-dev` Azure App Service
- **Environment**: Development

## 📋 Workflow Configuration

### Key Differences from Production Workflow

| Aspect | Production | Development |
|--------|------------|-------------|
| **Branch Trigger** | `main` | `dev` |
| **App Service** | `sky-webapi` | `sky-webapi-dev` |
| **Environment Name** | Production | Development |
| **Artifact Name** | `.net-app` | `.net-app-dev` |
| **Workflow Name** | sky-webapi | sky-webapi-dev (Development) |

### Shared Configuration
- **Runtime**: .NET 9.x
- **Build Configuration**: Release
- **Authentication**: Same Azure credentials (reusing secrets)
- **Deploy Action**: azure/webapps-deploy@v3

## ⚠️ Important Considerations & Potential Issues

### 1. **Azure Service Principal Permissions**
**Issue**: The GitHub Actions workflow uses the same Azure credentials for both environments.

**Recommendation**: 
```bash
# Verify the service principal has access to sky-webapi-dev
az webapp show --name sky-webapi-dev --resource-group app-service-rg
```

**If Access Issues Occur**:
- The service principal needs Contributor/Deployment permissions on `sky-webapi-dev`
- May need to add permissions in Azure Portal → App Service → Access Control (IAM)

### 2. **GitHub Environments Setup**
**Current**: Workflow references 'Development' environment
**Recommendation**: Create GitHub environment for better control

**Steps to Create**:
1. Go to GitHub repo → Settings → Environments
2. Create "Development" environment
3. Add protection rules if needed (approvals, branch restrictions)
4. Configure environment-specific secrets if needed

### 3. **Deployment Slot Configuration**
**Current**: Uses 'Production' slot for both environments
**Consideration**: Both prod and dev use the same slot name

**Options**:
- Keep as-is (standard for single-slot apps)
- Create development-specific slot if needed

### 4. **Secret Management**
**Current**: Reusing production Azure credentials
**Security Consideration**: Same service principal accesses both environments

**Best Practice Options**:
- **Option A**: Keep shared (simpler, current setup)
- **Option B**: Create separate service principal for development
- **Option C**: Use different secrets for different environments

### 5. **Database Connection**
**Status**: ✅ **Already Handled**
- App Service environment variables override local settings
- `sky-webapi-dev` configured with development database connection
- No code changes needed for database switching in Azure

## 🚀 Testing the Setup

### Immediate Test
```bash
# Make a small change and push to test the workflow
echo "# Development branch" >> README-DEV.md
git add README-DEV.md
git commit -m "Test development deployment workflow"
git push origin dev
```

### Verification Steps
1. **Check GitHub Actions**: Go to repo → Actions → Watch workflow run
2. **Check Deployment**: Visit https://sky-webapi-dev.azurewebsites.net
3. **Test API**: Verify endpoints work with development database
4. **Check Logs**: Monitor App Service logs for any issues

## 🔧 Quick Fixes for Common Issues

### If Deployment Fails with Permission Error
```bash
# Add contributor role to service principal for the dev app
az role assignment create \
  --assignee $SERVICE_PRINCIPAL_ID \
  --role Contributor \
  --scope /subscriptions/34db2036-2044-4833-b3e1-394f18589d31/resourceGroups/app-service-rg/providers/Microsoft.Web/sites/sky-webapi-dev
```

### If GitHub Environment Doesn't Exist
1. GitHub repo → Settings → Environments
2. New Environment → "Development"
3. Configure protection rules if needed

### If Different Azure Credentials Needed
Add new secrets in GitHub repo → Settings → Secrets:
- `DEV_AZUREAPPSERVICE_CLIENTID`
- `DEV_AZUREAPPSERVICE_TENANTID` 
- `DEV_AZUREAPPSERVICE_SUBSCRIPTIONID`

Then update the workflow to use dev-specific secrets.

## 📈 Workflow Benefits

### ✅ **Advantages of This Setup**
- **Automatic Deployment**: Push to `dev` → Auto-deploy to development environment
- **Isolation**: Development deployments don't affect production
- **Same Build Process**: Consistent build/deploy pipeline
- **Easy Testing**: Test changes in development before merging to main
- **Database Isolation**: Development uses separate database

### 🔄 **Development Workflow**
1. **Feature Development**: Work on `dev` branch locally
2. **Local Testing**: Use `switch-database.ps1 dev` for local development
3. **Push to Dev**: Triggers automatic deployment to `sky-webapi-dev`
4. **Test in Cloud**: Test features on development app service
5. **Merge to Main**: When ready, merge `dev` → `main` for production

## 📋 Next Steps

1. **Test Deployment**: Make a commit to `dev` branch and watch workflow
2. **Verify Permissions**: Ensure service principal can deploy to dev app
3. **Set Up GitHub Environment**: Create "Development" environment if needed
4. **Team Training**: Share the new workflow with team members
5. **Documentation**: Update team docs with new development process

---

**Status**: ✅ **Complete** - Development branch and workflow ready  
**Ready for**: Testing deployment and team usage  
**Database**: Automatically uses development database (`sky-web-api-dev`)  
**Security**: Uses existing Azure credentials with appropriate permissions