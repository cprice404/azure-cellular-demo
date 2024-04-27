using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionConfig), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionConfig")]
    public interface IBuildDefinitionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#project_id BuildDefinition#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#repository BuildDefinition#repository}
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionRepository\"}")]
        azuredevops.BuildDefinition.IBuildDefinitionRepository Repository
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#agent_pool_name BuildDefinition#agent_pool_name}.</summary>
        [JsiiProperty(name: "agentPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentPoolName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ci_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#ci_trigger BuildDefinition#ci_trigger}
        /// </remarks>
        [JsiiProperty(name: "ciTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.BuildDefinition.IBuildDefinitionCiTrigger? CiTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#features BuildDefinition#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#id BuildDefinition#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#name BuildDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#path BuildDefinition#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>pull_request_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#pull_request_trigger BuildDefinition#pull_request_trigger}
        /// </remarks>
        [JsiiProperty(name: "pullRequestTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger? PullRequestTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#queue_status BuildDefinition#queue_status}.</summary>
        [JsiiProperty(name: "queueStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueueStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>schedules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#schedules BuildDefinition#schedules}
        /// </remarks>
        [JsiiProperty(name: "schedules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionSchedules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Schedules
        {
            get
            {
                return null;
            }
        }

        /// <summary>variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#variable BuildDefinition#variable}
        /// </remarks>
        [JsiiProperty(name: "variable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Variable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#variable_groups BuildDefinition#variable_groups}.</summary>
        [JsiiProperty(name: "variableGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? VariableGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionConfig), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#project_id BuildDefinition#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#repository BuildDefinition#repository}
            /// </remarks>
            [JsiiProperty(name: "repository", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionRepository\"}")]
            public azuredevops.BuildDefinition.IBuildDefinitionRepository Repository
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionRepository>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#agent_pool_name BuildDefinition#agent_pool_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentPoolName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ci_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#ci_trigger BuildDefinition#ci_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ciTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTrigger\"}", isOptional: true)]
            public azuredevops.BuildDefinition.IBuildDefinitionCiTrigger? CiTrigger
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionCiTrigger?>();
            }

            /// <summary>features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#features BuildDefinition#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Features
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#id BuildDefinition#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#name BuildDefinition#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#path BuildDefinition#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>pull_request_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#pull_request_trigger BuildDefinition#pull_request_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pullRequestTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger\"}", isOptional: true)]
            public azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger? PullRequestTrigger
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#queue_status BuildDefinition#queue_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queueStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueueStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>schedules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#schedules BuildDefinition#schedules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionSchedules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Schedules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>variable block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#variable BuildDefinition#variable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "variable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Variable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#variable_groups BuildDefinition#variable_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "variableGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? VariableGroups
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
