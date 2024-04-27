using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.GitRepository
{
    [JsiiInterface(nativeType: typeof(IGitRepositoryInitialization), fullyQualifiedName: "azuredevops.gitRepository.GitRepositoryInitialization")]
    public interface IGitRepositoryInitialization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#init_type GitRepository#init_type}.</summary>
        [JsiiProperty(name: "initType", typeJson: "{\"primitive\":\"string\"}")]
        string InitType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#service_connection_id GitRepository#service_connection_id}.</summary>
        [JsiiProperty(name: "serviceConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#source_type GitRepository#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#source_url GitRepository#source_url}.</summary>
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGitRepositoryInitialization), fullyQualifiedName: "azuredevops.gitRepository.GitRepositoryInitialization")]
        internal sealed class _Proxy : DeputyBase, azuredevops.GitRepository.IGitRepositoryInitialization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#init_type GitRepository#init_type}.</summary>
            [JsiiProperty(name: "initType", typeJson: "{\"primitive\":\"string\"}")]
            public string InitType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#service_connection_id GitRepository#service_connection_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceConnectionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#source_type GitRepository#source_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/git_repository#source_url GitRepository#source_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
