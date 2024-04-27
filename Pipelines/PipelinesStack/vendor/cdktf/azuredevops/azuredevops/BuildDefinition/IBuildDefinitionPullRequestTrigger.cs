using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionPullRequestTrigger), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger")]
    public interface IBuildDefinitionPullRequestTrigger
    {
        /// <summary>forks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#forks BuildDefinition#forks}
        /// </remarks>
        [JsiiProperty(name: "forks", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerForks\"}")]
        azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerForks Forks
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#comment_required BuildDefinition#comment_required}.</summary>
        [JsiiProperty(name: "commentRequired", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommentRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#initial_branch BuildDefinition#initial_branch}.</summary>
        [JsiiProperty(name: "initialBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitialBranch
        {
            get
            {
                return null;
            }
        }

        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#override BuildDefinition#override}
        /// </remarks>
        [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverride\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride? Override
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#use_yaml BuildDefinition#use_yaml}.</summary>
        [JsiiProperty(name: "useYaml", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseYaml
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionPullRequestTrigger), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>forks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#forks BuildDefinition#forks}
            /// </remarks>
            [JsiiProperty(name: "forks", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerForks\"}")]
            public azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerForks Forks
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerForks>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#comment_required BuildDefinition#comment_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commentRequired", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommentRequired
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#initial_branch BuildDefinition#initial_branch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialBranch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitialBranch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#override BuildDefinition#override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverride\"}", isOptional: true)]
            public azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride? Override
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#use_yaml BuildDefinition#use_yaml}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useYaml", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseYaml
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
