using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionRepository")]
    public class BuildDefinitionRepository : azuredevops.BuildDefinition.IBuildDefinitionRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#repo_id BuildDefinition#repo_id}.</summary>
        [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}")]
        public string RepoId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#repo_type BuildDefinition#repo_type}.</summary>
        [JsiiProperty(name: "repoType", typeJson: "{\"primitive\":\"string\"}")]
        public string RepoType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#yml_path BuildDefinition#yml_path}.</summary>
        [JsiiProperty(name: "ymlPath", typeJson: "{\"primitive\":\"string\"}")]
        public string YmlPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#branch_name BuildDefinition#branch_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "branchName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BranchName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#github_enterprise_url BuildDefinition#github_enterprise_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "githubEnterpriseUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GithubEnterpriseUrl
        {
            get;
            set;
        }

        private object? _reportBuildStatus;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#report_build_status BuildDefinition#report_build_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ReportBuildStatus
        {
            get => _reportBuildStatus;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _reportBuildStatus = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#service_connection_id BuildDefinition#service_connection_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceConnectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceConnectionId
        {
            get;
            set;
        }
    }
}
