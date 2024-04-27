using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionRepository), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionRepository")]
    public interface IBuildDefinitionRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#repo_id BuildDefinition#repo_id}.</summary>
        [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}")]
        string RepoId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#repo_type BuildDefinition#repo_type}.</summary>
        [JsiiProperty(name: "repoType", typeJson: "{\"primitive\":\"string\"}")]
        string RepoType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#yml_path BuildDefinition#yml_path}.</summary>
        [JsiiProperty(name: "ymlPath", typeJson: "{\"primitive\":\"string\"}")]
        string YmlPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#branch_name BuildDefinition#branch_name}.</summary>
        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BranchName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#github_enterprise_url BuildDefinition#github_enterprise_url}.</summary>
        [JsiiProperty(name: "githubEnterpriseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GithubEnterpriseUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#report_build_status BuildDefinition#report_build_status}.</summary>
        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReportBuildStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#service_connection_id BuildDefinition#service_connection_id}.</summary>
        [JsiiProperty(name: "serviceConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceConnectionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionRepository), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionRepository")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionRepository
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#repo_id BuildDefinition#repo_id}.</summary>
            [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}")]
            public string RepoId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#repo_type BuildDefinition#repo_type}.</summary>
            [JsiiProperty(name: "repoType", typeJson: "{\"primitive\":\"string\"}")]
            public string RepoType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#yml_path BuildDefinition#yml_path}.</summary>
            [JsiiProperty(name: "ymlPath", typeJson: "{\"primitive\":\"string\"}")]
            public string YmlPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#branch_name BuildDefinition#branch_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BranchName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#github_enterprise_url BuildDefinition#github_enterprise_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "githubEnterpriseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GithubEnterpriseUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#report_build_status BuildDefinition#report_build_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReportBuildStatus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#service_connection_id BuildDefinition#service_connection_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceConnectionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
