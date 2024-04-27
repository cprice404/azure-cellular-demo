using System;
using System.Collections.Generic;
using Constructs;
using HashiCorp.Cdktf;


namespace MyCompany.MyApp {

    record struct MainStackOptions(
        String CdkTfBackendAzureResourceGroupName,
        String CdkTfBackendAzureStorageAccountName,
        String CdkTfBackendAzureStorageContainerName,
        String AzureDevopsOrganizationUrl,
        String AzureDevopsPersonalAccessToken,
        String GithubPersonalAccessToken
    );
    
    class MainStack : TerraformStack
    {
        public MainStack(Construct scope, string id, MainStackOptions options) : base(scope, id)
        {
            var azureBackendConfig = new AzurermBackendConfig();
            azureBackendConfig.ResourceGroupName = options.CdkTfBackendAzureResourceGroupName;
            azureBackendConfig.StorageAccountName = options.CdkTfBackendAzureStorageAccountName;
            azureBackendConfig.ContainerName = options.CdkTfBackendAzureStorageContainerName;
            azureBackendConfig.Key = "PipelinesStack.tfstate";
            var azureBackend = new AzurermBackend(this, azureBackendConfig);
            
            var azuredevopsProviderConfig = new azuredevops.Provider.AzuredevopsProviderConfig();
            azuredevopsProviderConfig.OrgServiceUrl = options.AzureDevopsOrganizationUrl;
            azuredevopsProviderConfig.PersonalAccessToken = options.AzureDevopsPersonalAccessToken;
            
            var azuredevopsProvider = new azuredevops.Provider.AzuredevopsProvider(this, "azuredevopsProvider", azuredevopsProviderConfig);
            
            
            
            
            var projectConfig = new azuredevops.Project.ProjectConfig();
            projectConfig.Name = "myCdkTfProject";
            Console.WriteLine("TACO");
            var project = new azuredevops.Project.Project(this, "myproject", projectConfig);

            var githubServiceEndpointAuth = new azuredevops.ServiceendpointGithub.ServiceendpointGithubAuthPersonal();
            githubServiceEndpointAuth.PersonalAccessToken = options.GithubPersonalAccessToken;
            
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
            pipelineRepository.YmlPath = "Pipelines/sample-pipeline.yml";
            pipelineRepository.ServiceConnectionId = githubServiceEndpoint.Id;
            pipelineRepository.BranchName = "refs/heads/main";

            var pipelineVariables = new List<azuredevops.BuildDefinition.BuildDefinitionVariable>();
            pipelineVariables.Add(new azuredevops.BuildDefinition.BuildDefinitionVariable()
            {
                Name = "FOO",
                Value = "FOOOOOOOOO!"
            });
            pipelineVariables.Add(new azuredevops.BuildDefinition.BuildDefinitionVariable()
            {
                Name = "BAR",
                Value = "BAAAAAAAAAAR!"
            });
            
            // var pipelineCiTriggerOverride = new azuredevops.BuildDefinition.BuildDefinitionCiTriggerOverride();
            // pipelineCiTriggerOverride.BranchFilter =
            //     new List<azuredevops.BuildDefinition.BuildDefinitionCiTriggerOverrideBranchFilter>().ToArray();
            
            var pipelineCiTrigger = new azuredevops.BuildDefinition.BuildDefinitionCiTrigger();
            pipelineCiTrigger.UseYaml = true;
            // pipelineCiTrigger.Override = pipelineCiTriggerOverride; 

            // var pipelinePullRequestTriggerForks =
            //     new azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerForks();
            // pipelinePullRequestTriggerForks.Enabled = false;
            // pipelinePullRequestTriggerForks.ShareSecrets = false;
            //
            // var pipelinePullRequestTrigger = new azuredevops.BuildDefinition.BuildDefinitionPullRequestTrigger();
            // pipelinePullRequestTrigger.Forks = pipelinePullRequestTriggerForks;
                
            
            var pipelineConfig = new azuredevops.BuildDefinition.BuildDefinitionConfig();
            pipelineConfig.Name = "CoreInfrastructure";
            pipelineConfig.Repository = pipelineRepository;
            pipelineConfig.ProjectId = project.Id;
            pipelineConfig.Variable = pipelineVariables.ToArray();
            pipelineConfig.CiTrigger = pipelineCiTrigger;
            pipelineConfig.Path = "/application/Core";
            
            // pipelineConfig.PullRequestTrigger = pipelinePullRequestTrigger;
            var pipelineDefinition =
                new azuredevops.BuildDefinition.BuildDefinition(this, "CoreInfrastructurePipeline", pipelineConfig);
        }
    }
}