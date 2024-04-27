using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyBuildValidation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettings")]
    public class BranchPolicyBuildValidationSettings : azuredevops.BranchPolicyBuildValidation.IBranchPolicyBuildValidationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#build_definition_id BranchPolicyBuildValidation#build_definition_id}.</summary>
        [JsiiProperty(name: "buildDefinitionId", typeJson: "{\"primitive\":\"number\"}")]
        public double BuildDefinitionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#display_name BranchPolicyBuildValidation#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        private object _scope;

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#scope BranchPolicyBuildValidation#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettingsScope\"},\"kind\":\"array\"}}]}}")]
        public object Scope
        {
            get => _scope;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azuredevops.BranchPolicyBuildValidation.IBranchPolicyBuildValidationSettingsScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyBuildValidation.IBranchPolicyBuildValidationSettingsScope).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyBuildValidation.IBranchPolicyBuildValidationSettingsScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scope = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#filename_patterns BranchPolicyBuildValidation#filename_patterns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filenamePatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FilenamePatterns
        {
            get;
            set;
        }

        private object? _manualQueueOnly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#manual_queue_only BranchPolicyBuildValidation#manual_queue_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "manualQueueOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ManualQueueOnly
        {
            get => _manualQueueOnly;
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
                _manualQueueOnly = value;
            }
        }

        private object? _queueOnSourceUpdateOnly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#queue_on_source_update_only BranchPolicyBuildValidation#queue_on_source_update_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queueOnSourceUpdateOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? QueueOnSourceUpdateOnly
        {
            get => _queueOnSourceUpdateOnly;
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
                _queueOnSourceUpdateOnly = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#valid_duration BranchPolicyBuildValidation#valid_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ValidDuration
        {
            get;
            set;
        }
    }
}
