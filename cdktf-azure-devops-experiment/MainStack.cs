using System;
using Constructs;
using HashiCorp.Cdktf;


namespace MyCompany.MyApp {

    record struct MainStackOptions
    {
        public String azureDevopsOrganizationUrl;
        public String azureDevopsPersonalAccessToken;
        public String githubPersonalAccessToken;
    }
    
    class MainStack : TerraformStack
    {
        public MainStack(Construct scope, string id, MainStackOptions options) : base(scope, id)
        {
            var providerConfig = new azuredevops.Provider.AzuredevopsProviderConfig();
            providerConfig.OrgServiceUrl = options.azureDevopsOrganizationUrl;
            providerConfig.PersonalAccessToken = options.azureDevopsPersonalAccessToken;
            
            var provider = new azuredevops.Provider.AzuredevopsProvider(this, "azuredevopsProvider", providerConfig);
            var projectConfig = new azuredevops.Project.ProjectConfig();
            projectConfig.Name = "myCdkTfProject";
            Console.WriteLine("TACO");
            var project = new azuredevops.Project.Project(this, "myproject", projectConfig);

            var githubServiceEndpointAuth = new azuredevops.ServiceendpointGithub.ServiceendpointGithubAuthPersonal();
            githubServiceEndpointAuth.PersonalAccessToken = options.githubPersonalAccessToken;
            
            var githubServiceEndpointConfig = new azuredevops.ServiceendpointGithub.ServiceendpointGithubConfig();
            githubServiceEndpointConfig.ProjectId = project.Id;
            githubServiceEndpointConfig.ServiceEndpointName = "Github Service Connection";
            githubServiceEndpointConfig.AuthPersonal = githubServiceEndpointAuth;
            
            var githubServiceEndpoint =
                new azuredevops.ServiceendpointGithub.ServiceendpointGithub(this, "azureDevopsGithubEndpoint",
                    githubServiceEndpointConfig);
            

            var pipelineRepository = new azuredevops.BuildDefinition.BuildDefinitionRepository();
            pipelineRepository.RepoId = "cprice404/azure-cellular-demo";
            pipelineRepository.RepoType = "GitHub";
            pipelineRepository.YmlPath = "cdktf-azure/devops-experiment/cdktf-azure-pipeline.yml";
            pipelineRepository.ServiceConnectionId = githubServiceEndpoint.Id;
            pipelineRepository.BranchName = "main";
            
            var pipelineConfig = new azuredevops.BuildDefinition.BuildDefinitionConfig();
            pipelineConfig.Name = "myFirstPipeline";
            pipelineConfig.Repository = pipelineRepository;
            pipelineConfig.ProjectId = project.Id;
            var pipelineDefinition =
                new azuredevops.BuildDefinition.BuildDefinition(this, "myFirstPipeline", pipelineConfig);
        }
    }
}