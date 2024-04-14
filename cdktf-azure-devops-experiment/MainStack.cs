using System;
using Constructs;
using HashiCorp.Cdktf;
using azuredevops.Project;


namespace MyCompany.MyApp {

    record struct MainStackOptions
    {
        public String personalAccessToken;
        public String azureDevopsOrganizationUrl;
    }
    
    class MainStack : TerraformStack
    {
        public MainStack(Construct scope, string id, MainStackOptions options) : base(scope, id)
        {
            var providerConfig = new azuredevops.Provider.AzuredevopsProviderConfig();
            providerConfig.PersonalAccessToken = options.personalAccessToken;
            providerConfig.OrgServiceUrl = options.azureDevopsOrganizationUrl;
            var provider = new azuredevops.Provider.AzuredevopsProvider(this, "azuredevopsProvider", providerConfig);
            var projectConfig = new ProjectConfig();
            projectConfig.Name = "myCdkTfProject";
            Console.WriteLine("TACO");
            var project = new Project(this, "myproject", projectConfig);
        }
    }
}