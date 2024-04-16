using azure_cdktf_utils;
using Constructs;
using HashiCorp.Cdktf;

namespace CoreInfrastructure;

class CoreInfrastructureStack : TerraformStack
{
    public CoreInfrastructureStack(Construct scope, string id) : base(scope, id)
    {
        AzureCdkTfUtils.RegisterAzureProviderAndBackend(
            
            stackName: "CoreInfrastructure",
            stack: this
        );
    }
}