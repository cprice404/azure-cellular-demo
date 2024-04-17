using CellRegistry;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Azurerm.Provider;

namespace AzureCdktfUtils;

public static class AzureCdkTfUtils
{
    public static void RegisterAzureProviderAndBackend(
        AzureBackendStorageContainer backendStorageContainer,
        string stackName,
        TerraformStack stack
    )
    {
        var azureBackendConfig = new AzurermBackendConfig();
        azureBackendConfig.ResourceGroupName = backendStorageContainer.ResourceGroupName;
        azureBackendConfig.StorageAccountName = backendStorageContainer.StorageAccountName;
        azureBackendConfig.ContainerName = backendStorageContainer.ContainerName;
        azureBackendConfig.Key = $"{stackName}.tfstate";
        var azureBackend = new AzurermBackend(stack, azureBackendConfig);

        var azureProvider = new AzurermProvider(stack, "azure", new AzurermProviderConfig 
            {
                Features = new AzurermProviderFeatures()
                {
                    
                }
            }
        );
    }
}