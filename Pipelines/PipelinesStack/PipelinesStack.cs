using System;
using System.Collections.Generic;
using azuredevops.BuildDefinition;
using azuredevops.Project;
using azuredevops.Provider;
using azuredevops.ServiceendpointGithub;
using Constructs;
using HashiCorp.Cdktf;

namespace PipelinesStack {

    record struct PipelinesStackOptions(
        String CdkTfBackendAzureResourceGroupName,
        String CdkTfBackendAzureStorageAccountName,
        String CdkTfBackendAzureStorageContainerName,
        String AzureDevopsOrganizationUrl,
        String AzureDevopsPersonalAccessToken,
        String GithubPersonalAccessToken
    );
    
    class PipelinesStack : TerraformStack
    {
        public PipelinesStack(Construct scope, string id, PipelinesStackOptions options) : base(scope, id)
        {
            var azureBackendConfig = new AzurermBackendConfig();
            azureBackendConfig.ResourceGroupName = options.CdkTfBackendAzureResourceGroupName;
            azureBackendConfig.StorageAccountName = options.CdkTfBackendAzureStorageAccountName;
            azureBackendConfig.ContainerName = options.CdkTfBackendAzureStorageContainerName;
            azureBackendConfig.Key = "PipelinesStack.tfstate";
            var azureBackend = new AzurermBackend(this, azureBackendConfig);

            var azuredevopsProviderConfig = new AzuredevopsProviderConfig();
            azuredevopsProviderConfig.OrgServiceUrl = options.AzureDevopsOrganizationUrl;
            azuredevopsProviderConfig.PersonalAccessToken = options.AzureDevopsPersonalAccessToken;

            var azuredevopsProvider =
                new AzuredevopsProvider(this, "azuredevopsProvider", azuredevopsProviderConfig);




            var projectConfig = new ProjectConfig();
            projectConfig.Name = "Azure Cellular Demo";
            var project = new Project(this, "myproject", projectConfig);

            var githubServiceEndpointAuth = new ServiceendpointGithubAuthPersonal();
            githubServiceEndpointAuth.PersonalAccessToken = options.GithubPersonalAccessToken;

            var githubServiceEndpointConfig = new ServiceendpointGithubConfig();
            githubServiceEndpointConfig.ProjectId = project.Id;
            githubServiceEndpointConfig.ServiceEndpointName = "Github Service Connection";
            githubServiceEndpointConfig.AuthPersonal = githubServiceEndpointAuth;

            var githubServiceEndpoint =
                new ServiceendpointGithub(this, "azureDevopsGithubEndpoint",
                    githubServiceEndpointConfig);


            var pipelineRepository = new BuildDefinitionRepository();
            pipelineRepository.RepoId = "cprice404/azure-cellular-demo";
            pipelineRepository.RepoType = "GitHub";
            pipelineRepository.YmlPath = "Pipelines/PipelinesStack/sample-pipeline.yml";
            pipelineRepository.ServiceConnectionId = githubServiceEndpoint.Id;
            pipelineRepository.BranchName = "refs/heads/main";

            var pipelineVariables = new List<BuildDefinitionVariable>();
            pipelineVariables.Add(new BuildDefinitionVariable
            {
                Name = "FOO",
                Value = "FOOOOOOOOO!"
            });
            pipelineVariables.Add(new BuildDefinitionVariable
            {
                Name = "BAR",
                Value = "BAAAAAAAAAAR!"
            });

            // var pipelineCiTriggerOverride = new azuredevops.BuildDefinition.BuildDefinitionCiTriggerOverride();
            // pipelineCiTriggerOverride.BranchFilter =
            //     new List<azuredevops.BuildDefinition.BuildDefinitionCiTriggerOverrideBranchFilter>().ToArray();

            var pipelineCiTrigger = new BuildDefinitionCiTrigger();
            pipelineCiTrigger.UseYaml = true;
            // pipelineCiTrigger.Override = new BuildDefinitionCiTriggerOverride
            // {
            //     PathFilter = new List<BuildDefinitionCiTriggerOverridePathFilter>
            //     {
            //         new()
            //         {
            //             Include = new[] {"/application/Core/**"} 
            //         }
            //     }.ToArray()
            // };
        // pipelineCiTrigger.Override = pipelineCiTriggerOverride; 

            // var pipelinePullRequestTriggerForks =
            //     new azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerForks();
            // pipelinePullRequestTriggerForks.Enabled = false;
            // pipelinePullRequestTriggerForks.ShareSecrets = false;
            //
            // var pipelinePullRequestTrigger = new azuredevops.BuildDefinition.BuildDefinitionPullRequestTrigger();
            // pipelinePullRequestTrigger.Forks = pipelinePullRequestTriggerForks;
                
            
            var pipelineConfig = new BuildDefinitionConfig();
            pipelineConfig.Name = "CoreInfrastructure";
            pipelineConfig.Repository = pipelineRepository;
            pipelineConfig.ProjectId = project.Id;
            pipelineConfig.Variable = pipelineVariables.ToArray();
            pipelineConfig.CiTrigger = pipelineCiTrigger;
            // pipelineConfig.Path = "\\application\\Core";
            
            // pipelineConfig.PullRequestTrigger = pipelinePullRequestTrigger;
            var pipelineDefinition =
                new BuildDefinition(this, "CoreInfrastructurePipeline", pipelineConfig);

            var pipelineOfPipelinesDefinition = new BuildDefinition(this, "PipelineOfPipelines",
                new BuildDefinitionConfig()
                {
                    Name = "PipelineOfPipelines",
                    Repository = new BuildDefinitionRepository()
                    {
                        RepoId = "cprice404/azure-cellular-demo",
                        RepoType = "GitHub",
                        YmlPath = "Pipelines/PipelinesStack/pipeline-of-pipelines.yml",
                        ServiceConnectionId = githubServiceEndpoint.Id,
                        BranchName = "refs/heads/main"
                    },
                    ProjectId = project.Id,
                    CiTrigger = new BuildDefinitionCiTrigger()
                    {
                        UseYaml = true
                    }
                });
        }
    }
}