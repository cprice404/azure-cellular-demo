using AzureCdktfUtils;
using CellRegistry;
using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Azurerm.ResourceGroup;

namespace TimeServiceInfrastructure
{
    class TimeServiceInfrastructureStack : TerraformStack
    {
        public record struct Options(
            AzureBackendStorageContainer BackendStorageContainer,
            string Location,
            string CellName
        );
        
        public TimeServiceInfrastructureStack(Construct scope, string id, Options options) : base(scope, id)
        {
            AzureCdkTfUtils.RegisterAzureProviderAndBackend(
                backendStorageContainer: options.BackendStorageContainer,
                stackName: "TimeServiceInfrastructure",
                stack: this
            );

            ResourceGroup rg = new ResourceGroup(this, "timeservice-infra-rg", new ResourceGroupConfig
            {
                Name = "azure-cellular-demo-timeservice-infra-rg",
                Location = options.Location
            });
        }
    }
}