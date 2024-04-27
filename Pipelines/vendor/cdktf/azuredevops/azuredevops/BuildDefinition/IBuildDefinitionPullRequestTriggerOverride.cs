using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionPullRequestTriggerOverride), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverride")]
    public interface IBuildDefinitionPullRequestTriggerOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#auto_cancel BuildDefinition#auto_cancel}.</summary>
        [JsiiProperty(name: "autoCancel", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoCancel
        {
            get
            {
                return null;
            }
        }

        /// <summary>branch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
        /// </remarks>
        [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverrideBranchFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BranchFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#path_filter BuildDefinition#path_filter}
        /// </remarks>
        [JsiiProperty(name: "pathFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverridePathFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PathFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionPullRequestTriggerOverride), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverride")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#auto_cancel BuildDefinition#auto_cancel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoCancel", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoCancel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>branch_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverrideBranchFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BranchFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>path_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#path_filter BuildDefinition#path_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverridePathFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PathFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
