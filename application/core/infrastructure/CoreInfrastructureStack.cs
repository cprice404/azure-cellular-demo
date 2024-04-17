using AzureCdktfUtils;
using CellRegistry;
using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Azurerm.KubernetesCluster;
using HashiCorp.Cdktf.Providers.Azurerm.ResourceGroup;

namespace CoreInfrastructure;

class CoreInfrastructureStack : TerraformStack
{
    public CoreInfrastructureStack(Construct scope, string id, AzureBackendStorageContainer backendStorageContainer, string location) : base(scope, id)
    {
        AzureCdkTfUtils.RegisterAzureProviderAndBackend(
            backendStorageContainer: backendStorageContainer,
            stackName: "CoreInfrastructure",
            stack: this
        );

        ResourceGroup rg = new ResourceGroup(this, "core-infra-rg", new ResourceGroupConfig
        {
            Name = "azure-cellular-demo-core-infra-rg",
            Location = location
        });

        KubernetesClusterServicePrincipal sp = new KubernetesClusterServicePrincipal();
        
        KubernetesCluster cluster = new KubernetesCluster(this, "k8s-cluster", new KubernetesClusterConfig
        {
            Name = "azure-cellular-demo-k8s-cluster",
            ResourceGroupName = rg.Name,
            DefaultNodePool = new KubernetesClusterDefaultNodePool
            {
                Name = "default",
                NodeCount = 1,
                VmSize = "Standard_B1ms"
            },
            Location = location,
            DnsPrefixPrivateCluster = "azure-cellular-demo",
            ServicePrincipal = 
        });
    }
}