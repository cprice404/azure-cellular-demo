using System;
using azuredevops.Project;
using azuredevops.Provider;
using azuredevops.ServiceendpointGithub;
using azuredevops.BuildDefinition;
using Constructs;
using HashiCorp.Cdktf;
using PipelinesGenerator;

namespace PipelinesStack {

    record struct PipelinesStackOptions(
        String CdkTfBackendAzureResourceGroupName,
        String CdkTfBackendAzureStorageAccountName,
        String CdkTfBackendAzureStorageContainerName,
        String AzureDevopsOrganizationUrl,
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

            var azuredevopsProvider =
                new AzuredevopsProvider(this, "azuredevopsProvider", azuredevopsProviderConfig);

            var projectConfig = new ProjectConfig();
            projectConfig.Name = "Azure Cellular Demo";
            var project = new Project(this, "azure-cellular-demo-project", projectConfig);

            var githubServiceEndpointAuth = new ServiceendpointGithubAuthPersonal();
            githubServiceEndpointAuth.PersonalAccessToken = options.GithubPersonalAccessToken;

            var githubServiceEndpointConfig = new ServiceendpointGithubConfig();
            githubServiceEndpointConfig.ProjectId = project.Id;
            githubServiceEndpointConfig.ServiceEndpointName = "Github Service Connection";
            githubServiceEndpointConfig.AuthPersonal = githubServiceEndpointAuth;

            var githubServiceEndpoint =
                new ServiceendpointGithub(this, "azureDevopsGithubEndpoint",
                    githubServiceEndpointConfig);

            var pipelineOfPipelinesDefinition = new BuildDefinition(this, "PipelineOfPipelines",
                GeneratePipelineConfig(githubServiceEndpoint, project, "PipelineOfPipelines",
                    "Pipelines/PipelinesStack/pipeline-of-pipelines.yml")
                );

            foreach (var component in ApplicationComponents.AllComponents)
            {
                var componentPipeline = new azuredevops.BuildDefinition.BuildDefinition(
                    this, 
                    $"{component.PipelineName}Pipeline",
                    GeneratePipelineConfig(githubServiceEndpoint, project, component.PipelineName,
                        $"Pipelines/generated-pipeline-yml/{component.PipelineName}.yml")
                );
            }
        }

        private BuildDefinitionConfig GeneratePipelineConfig(
            ServiceendpointGithub githubServiceEndpoint,
            Project project,
            String pipelineName,
            String ymlPath
        )
        {
            return new BuildDefinitionConfig()
            {
                Name = pipelineName,
                Repository = new BuildDefinitionRepository()
                {
                    RepoId = "cprice404/azure-cellular-demo",
                    RepoType = "GitHub",
                    YmlPath = ymlPath,
                    ServiceConnectionId = githubServiceEndpoint.Id,
                    BranchName = "refs/heads/main"
                },
                ProjectId = project.Id,
                CiTrigger = new BuildDefinitionCiTrigger()
                {
                    UseYaml = true
                }
            };
        }
    }
}