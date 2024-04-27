using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverride")]
    public class BuildDefinitionPullRequestTriggerOverride : azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride
    {
        private object? _autoCancel;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#auto_cancel BuildDefinition#auto_cancel}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoCancel", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoCancel
        {
            get => _autoCancel;
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
                _autoCancel = value;
            }
        }

        private object? _branchFilter;

        /// <summary>branch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverrideBranchFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BranchFilter
        {
            get => _branchFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverrideBranchFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverrideBranchFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _branchFilter = value;
            }
        }

        private object? _pathFilter;

        /// <summary>path_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#path_filter BuildDefinition#path_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverridePathFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PathFilter
        {
            get => _pathFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverridePathFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverridePathFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pathFilter = value;
            }
        }
    }
}
