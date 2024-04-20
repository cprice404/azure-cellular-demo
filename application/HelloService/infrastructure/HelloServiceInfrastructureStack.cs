using System.Collections.Generic;
using AzureCdktfUtils;
using CellRegistry;
using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Azurerm.DataAzurermContainerRegistry;
using HashiCorp.Cdktf.Providers.Azurerm.LinuxWebApp;
using HashiCorp.Cdktf.Providers.Azurerm.ResourceGroup;
using HashiCorp.Cdktf.Providers.Azurerm.RoleAssignment;
using HashiCorp.Cdktf.Providers.Azurerm.ServicePlan;

namespace HelloServiceInfrastructure
{
    class HelloServiceInfrastructureStack : TerraformStack
    {
        public record struct Options(
            AzureBackendStorageContainer BackendStorageContainer,
            string Location,
            string CellName,
            string CoreInfrastructureResourceGroupName
        );
        
        public HelloServiceInfrastructureStack(Construct scope, string id, Options options) : base(scope, id)
        {
            AzureCdkTfUtils.RegisterAzureProviderAndBackend(
                backendStorageContainer: options.BackendStorageContainer,
                stackName: "HelloServiceInfrastructure",
                stack: this
            );

            ResourceGroup rg = new ResourceGroup(this, "helloservice-infra-rg", new ResourceGroupConfig() {
                Name = "azure-cellular-demo-helloservice-infra-rg",
                Location = options.Location
            });
            
            
            var asp = new ServicePlan(this, "helloservice-asp", new ServicePlanConfig() {
                Name = "helloservice-asp",
                // Kind = "Linux",
                // Reserved = true,
                ResourceGroupName = rg.Name,
                Location = options.Location,
                // Sku = new AppServicePlanSku()
                // {
                //     Tier = "Free",
                //     Size = "B1"
                // }
                OsType = "Linux",
                SkuName = "B1",
            });

            var app = new LinuxWebApp(this, "helloservice-app", new LinuxWebAppConfig()
            {
                Name = $"helloservice-{options.CellName}",
                Location = options.Location,
                ServicePlanId = asp.Id,
                ResourceGroupName = rg.Name,
                ClientAffinityEnabled = false,
                HttpsOnly = false,
                SiteConfig = new LinuxWebAppSiteConfig()
                {
                    ContainerRegistryUseManagedIdentity = true,
                    ApplicationStack = new LinuxWebAppSiteConfigApplicationStack()
                    {
                        DockerRegistryUrl = "https://azurecelldemodeveloperchris.azurecr.io",
                        DockerImageName = "helloservice:v0.0.1",
                    },
                },
                Identity = new LinuxWebAppIdentity()
                {
                    Type = "SystemAssigned"
                },
                AppSettings = new Dictionary<string, string>()
                {
                    {"WEBSITES_PORT", "8080"}
                }
            });

            var acr = new DataAzurermContainerRegistry(this, "azure-cell-demo-acr",
                new DataAzurermContainerRegistryConfig()
                {
                    Name = $"azurecelldemo{options.CellName}",
                    ResourceGroupName = options.CoreInfrastructureResourceGroupName,
                });
            
            var aksAcrRoleAssignment = new RoleAssignment(this, "aks-acr-role-assignment", new RoleAssignmentConfig()
            {
                PrincipalId = app.Identity.PrincipalId,
                RoleDefinitionName = "AcrPull",
                Scope = acr.Id
            });
        }
    }
}