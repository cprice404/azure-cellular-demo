using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.GitRepository
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.gitRepository.GitRepositoryInitialization")]
    public class GitRepositoryInitialization : azuredevops.GitRepository.IGitRepositoryInitialization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#init_type GitRepository#init_type}.</summary>
        [JsiiProperty(name: "initType", typeJson: "{\"primitive\":\"string\"}")]
        public string InitType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#service_connection_id GitRepository#service_connection_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#source_type GitRepository#source_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#source_url GitRepository#source_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceUrl
        {
            get;
            set;
        }
    }
}
