using System.Collections.Generic;
using AzureCdktfUtils;
using CellRegistry;
using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Azurerm.DataAzurermAppConfiguration;
using HashiCorp.Cdktf.Providers.Azurerm.DataAzurermAppConfigurationKey;
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
            string CoreInfrastructureResourceGroupName,
            string HelloServiceVersion
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

            var appConfig = new DataAzurermAppConfiguration(this, "app-config", new DataAzurermAppConfigurationConfig()
            {
                Name = "azure-cellular-demo-appconfig",
                ResourceGroupName = options.CoreInfrastructureResourceGroupName
            });
            
            var timeServiceAddressKey = new DataAzurermAppConfigurationKey(this, "time-service-address-key", new DataAzurermAppConfigurationKeyConfig()
            {
                Key = "timeservice_address",
                ConfigurationStoreId = appConfig.Id,
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
                        DockerImageName = $"helloservice:v{options.HelloServiceVersion}",
                    },
                },
                Identity = new LinuxWebAppIdentity()
                {
                    Type = "SystemAssigned"
                },
                AppSettings = new Dictionary<string, string>()
                {
                    { "WEBSITES_PORT", "8080" },
                    { "HELLO_SERVICE_VERSION", options.HelloServiceVersion },
                    { "TIME_SERVICE_ADDRESS", timeServiceAddressKey.Value }
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