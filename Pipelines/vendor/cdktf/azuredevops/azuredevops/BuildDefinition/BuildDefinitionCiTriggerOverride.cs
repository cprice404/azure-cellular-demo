using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionCiTriggerOverride")]
    public class BuildDefinitionCiTriggerOverride : azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride
    {
        private object? _batch;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#batch BuildDefinition#batch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Batch
        {
            get => _batch;
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
                _batch = value;
            }
        }

        private object? _branchFilter;

        /// <summary>branch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#branch_filter BuildDefinition#branch_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverrideBranchFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverrideBranchFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverrideBranchFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _branchFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#max_concurrent_builds_per_branch BuildDefinition#max_concurrent_builds_per_branch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentBuildsPerBranch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentBuildsPerBranch
        {
            get;
            set;
        }

        private object? _pathFilter;

        /// <summary>path_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#path_filter BuildDefinition#path_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pathFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverridePathFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverridePathFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverridePathFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pathFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#polling_interval BuildDefinition#polling_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pollingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PollingInterval
        {
            get;
            set;
        }
    }
}
