using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyBuildValidation
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyBuildValidationSettings), fullyQualifiedName: "azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettings")]
    public interface IBranchPolicyBuildValidationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#build_definition_id BranchPolicyBuildValidation#build_definition_id}.</summary>
        [JsiiProperty(name: "buildDefinitionId", typeJson: "{\"primitive\":\"number\"}")]
        double BuildDefinitionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#display_name BranchPolicyBuildValidation#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#scope BranchPolicyBuildValidation#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettingsScope\"},\"kind\":\"array\"}}]}}")]
        object Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#filename_patterns BranchPolicyBuildValidation#filename_patterns}.</summary>
        [JsiiProperty(name: "filenamePatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FilenamePatterns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#manual_queue_only BranchPolicyBuildValidation#manual_queue_only}.</summary>
        [JsiiProperty(name: "manualQueueOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManualQueueOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#queue_on_source_update_only BranchPolicyBuildValidation#queue_on_source_update_only}.</summary>
        [JsiiProperty(name: "queueOnSourceUpdateOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueueOnSourceUpdateOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#valid_duration BranchPolicyBuildValidation#valid_duration}.</summary>
        [JsiiProperty(name: "validDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValidDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyBuildValidationSettings), fullyQualifiedName: "azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettings")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyBuildValidation.IBranchPolicyBuildValidationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#build_definition_id BranchPolicyBuildValidation#build_definition_id}.</summary>
            [JsiiProperty(name: "buildDefinitionId", typeJson: "{\"primitive\":\"number\"}")]
            public double BuildDefinitionId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#display_name BranchPolicyBuildValidation#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#scope BranchPolicyBuildValidation#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettingsScope\"},\"kind\":\"array\"}}]}}")]
            public object Scope
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#filename_patterns BranchPolicyBuildValidation#filename_patterns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filenamePatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FilenamePatterns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#manual_queue_only BranchPolicyBuildValidation#manual_queue_only}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "manualQueueOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ManualQueueOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#queue_on_source_update_only BranchPolicyBuildValidation#queue_on_source_update_only}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queueOnSourceUpdateOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? QueueOnSourceUpdateOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#valid_duration BranchPolicyBuildValidation#valid_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValidDuration
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
