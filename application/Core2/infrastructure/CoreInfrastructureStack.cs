using System.Collections.Generic;
using AzureCdktfUtils;
using CellRegistry;
using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Azurerm.AppConfiguration;
using HashiCorp.Cdktf.Providers.Azurerm.AppConfigurationKey;
using HashiCorp.Cdktf.Providers.Azurerm.ContainerRegistry;
using HashiCorp.Cdktf.Providers.Azurerm.DataAzurermClientConfig;
using HashiCorp.Cdktf.Providers.Azurerm.KubernetesCluster;
using HashiCorp.Cdktf.Providers.Azurerm.ResourceGroup;
using HashiCorp.Cdktf.Providers.Azurerm.RoleAssignment;

namespace CoreInfrastructure;

class CoreInfrastructureStack : TerraformStack
{
    
    public record struct Options(
        AzureBackendStorageContainer BackendStorageContainer,
        string Location,
        string CellName,
        string CoreInfrastructureResourceGroupName
    );
    public CoreInfrastructureStack(Construct scope, string id, Options options) : base(scope, id)
    {
        AzureCdkTfUtils.RegisterAzureProviderAndBackend(
            backendStorageContainer: options.BackendStorageContainer,
            stackName: "CoreInfrastructure",
            stack: this
        );

        ResourceGroup rg = new ResourceGroup(this, "core-infra-rg", new ResourceGroupConfig
        {
            Name = options.CoreInfrastructureResourceGroupName,
            Location = options.Location
        });

        KubernetesCluster cluster = new KubernetesCluster(this, "k8s-cluster", new KubernetesClusterConfig
        {
            Name = "azure-cellular-demo-k8s-cluster",
            ResourceGroupName = rg.Name,
            DefaultNodePool = new KubernetesClusterDefaultNodePool
            {
                Name = "default",
                NodeCount = 1,
                VmSize = "Standard_B2s",
                UpgradeSettings = new KubernetesClusterDefaultNodePoolUpgradeSettings()
                {
                    MaxSurge = "10%"
                }
            },
            Location = options.Location,
            DnsPrefix = "azure-cellular-demo",
            OidcIssuerEnabled = true,
            WorkloadIdentityEnabled = true,
            Identity = new KubernetesClusterIdentity()
            {
                Type = "SystemAssigned"
            }
        });

        var kubeConfigOutput = new TerraformOutput(this, "kube_config", new TerraformOutputConfig()
        {
            Value = cluster.KubeConfigRaw,
            Sensitive = true
        });
        
        
        var containerRegistry = new ContainerRegistry(this, "azure-cellular-demo-acr", new ContainerRegistryConfig()
        {
            Name = $"azurecelldemo{options.CellName}",
            ResourceGroupName = rg.Name,
            Location = options.Location,
            Sku = "Basic"
        });
        
        var aksAcrRoleAssignment = new RoleAssignment(this, "aks-acr-role-assignment", new RoleAssignmentConfig()
        {
            PrincipalId = cluster.KubeletIdentity.ObjectId,
            RoleDefinitionName = "AcrPull",
            Scope = containerRegistry.Id
        });

        var appConfigStore = new AppConfiguration(this, "azure-cellular-demo-appconfig", new AppConfigurationConfig()
        {
            Name = $"azure-cellular-demo-appconfig-{options.CellName}",
            ResourceGroupName = rg.Name,
            Location = options.Location
        });

        var appConfigDataOwner = new RoleAssignment(this, "azure-cellular-demo-appconfig-dataowner",
            new RoleAssignmentConfig()
            {
                PrincipalId = new DataAzurermClientConfig(this, "azure-client-config",
                    new DataAzurermClientConfigConfig()
                    {

                    }).ObjectId,
                RoleDefinitionName = "App Configuration Data Owner",
                Scope = appConfigStore.Id
            });

        new AppConfigurationKey(this, "azure-cellular-demo-appconfig-samplekey", new AppConfigurationKeyConfig()
        {
            ConfigurationStoreId = appConfigStore.Id,
            Key = "samplekey",
            Value = "samplevalue",
            Timeouts = new AppConfigurationKeyTimeouts()
            {
                Create = "2m",
                Delete = "2m",
                Update = "2m"
            },
            DependsOn = (new List<ITerraformDependable>() {appConfigDataOwner}).ToArray()
        });
    }
}