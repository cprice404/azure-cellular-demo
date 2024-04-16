using HashiCorp.Cdktf;

namespace azure_cdktf_utils;

public class AzureCdkTfUtils
{
    public record struct BackendStorageContainer(
        string ResourceGroupName,
        string StorageAccountName,
        string ContainerName
    );
    public static void RegisterAzureProviderAndBackend(
        BackendStorageContainer backendStorageContainer,
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
    }
}