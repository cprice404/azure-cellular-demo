using AzureCdktfUtils;
using CellRegistry;
using Constructs;
using HashiCorp.Cdktf;

namespace CoreInfrastructure;

class CoreInfrastructureStack : TerraformStack
{
    public CoreInfrastructureStack(Construct scope, string id, AzureBackendStorageContainer backendStorageContainer) : base(scope, id)
    {
        AzureCdkTfUtils.RegisterAzureProviderAndBackend(
            backendStorageContainer: backendStorageContainer,
            stackName: "CoreInfrastructure",
            stack: this
        );
    }
}