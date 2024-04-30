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
            Console.WriteLine("Azure Storage Account Resource Group Name: " + azureBackendConfig.ResourceGroupName);
            azureBackendConfig.StorageAccountName = options.CdkTfBackendAzureStorageAccountName;
            azureBackendConfig.ContainerName = options.CdkTfBackendAzureStorageContainerName;
            azureBackendConfig.Key = "PipelinesStack.tfstate";
            var azureBackend = new AzurermBackend(this, azureBackendConfig);

            var azuredevopsProviderConfig = new AzuredevopsProviderConfig();
            azuredevopsProviderConfig.OrgServiceUrl = options.AzureDevopsOrganizationUrl;
            // azuredevopsProviderConfig.PersonalAccessToken = options.AzureDevopsPersonalAccessToken;
            // azuredevopsProviderConfig.UseMsi = true;
            // azuredevopsProviderConfig.ClientId = "319b5344-422f-4c8d-81eb-0023bce1f0a4";
            // azuredevopsProviderConfig.TenantId = "8388c21f-2c8e-4c4a-915c-546dc979fce6";
            // azuredevopsProviderConfig.ClientSecret = Environment.GetEnvironmentVariable("ARM_CLIENT_SECRET");
                /*
                 * [
                     {
                       "cloudName": "AzureCloud",
                       "homeTenantId": "8388c21f-2c8e-4c4a-915c-546dc979fce6",
                       "id": "4b68fc4a-318e-4926-aad5-9375fa772fe3",
                       "isDefault": true,
                       "managedByTenants": [],
                       "name": "Azure subscription 1",
                       "state": "Enabled",
                       "tenantId": "8388c21f-2c8e-4c4a-915c-546dc979fce6",
                       "user": {
                         "name": "***",
                         "type": "servicePrincipal"
                       }
                     }
                   ]
                   
                 */

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


        //     var pipelineRepository = new BuildDefinitionRepository();
        //     pipelineRepository.RepoId = "cprice404/azure-cellular-demo";
        //     pipelineRepository.RepoType = "GitHub";
        //     pipelineRepository.YmlPath = "Pipelines/PipelinesStack/sample-pipeline.yml";
        //     pipelineRepository.ServiceConnectionId = githubServiceEndpoint.Id;
        //     pipelineRepository.BranchName = "refs/heads/main";
        //
        //     var pipelineVariables = new List<BuildDefinitionVariable>();
        //     pipelineVariables.Add(new BuildDefinitionVariable
        //     {
        //         Name = "FOO",
        //         Value = "FOOOOOOOOO!"
        //     });
        //     pipelineVariables.Add(new BuildDefinitionVariable
        //     {
        //         Name = "BAR",
        //         Value = "BAAAAAAAAAAR!"
        //     });
        //
        //     // var pipelineCiTriggerOverride = new azuredevops.BuildDefinition.BuildDefinitionCiTriggerOverride();
        //     // pipelineCiTriggerOverride.BranchFilter =
        //     //     new List<azuredevops.BuildDefinition.BuildDefinitionCiTriggerOverrideBranchFilter>().ToArray();
        //
        //     var pipelineCiTrigger = new BuildDefinitionCiTrigger();
        //     pipelineCiTrigger.UseYaml = true;
        //     // pipelineCiTrigger.Override = new BuildDefinitionCiTriggerOverride
        //     // {
        //     //     PathFilter = new List<BuildDefinitionCiTriggerOverridePathFilter>
        //     //     {
        //     //         new()
        //     //         {
        //     //             Include = new[] {"/application/Core/**"} 
        //     //         }
        //     //     }.ToArray()
        //     // };
        // // pipelineCiTrigger.Override = pipelineCiTriggerOverride; 
        //
        //     // var pipelinePullRequestTriggerForks =
        //     //     new azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerForks();
        //     // pipelinePullRequestTriggerForks.Enabled = false;
        //     // pipelinePullRequestTriggerForks.ShareSecrets = false;
        //     //
        //     // var pipelinePullRequestTrigger = new azuredevops.BuildDefinition.BuildDefinitionPullRequestTrigger();
        //     // pipelinePullRequestTrigger.Forks = pipelinePullRequestTriggerForks;
        //         
        //     
        //     var pipelineConfig = new BuildDefinitionConfig();
        //     pipelineConfig.Name = "CoreInfrastructure";
        //     pipelineConfig.Repository = pipelineRepository;
        //     pipelineConfig.ProjectId = project.Id;
        //     pipelineConfig.Variable = pipelineVariables.ToArray();
        //     pipelineConfig.CiTrigger = pipelineCiTrigger;
        //     // pipelineConfig.Path = "\\application\\Core";
        //     
        //     // pipelineConfig.PullRequestTrigger = pipelinePullRequestTrigger;
        //     var pipelineDefinition =
        //         new BuildDefinition(this, "CoreInfrastructurePipeline", pipelineConfig);

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