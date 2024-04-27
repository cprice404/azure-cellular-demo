using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyMergeTypes
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyMergeTypesSettings), fullyQualifiedName: "azuredevops.branchPolicyMergeTypes.BranchPolicyMergeTypesSettings")]
    public interface IBranchPolicyMergeTypesSettings
    {
        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#scope BranchPolicyMergeTypes#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyMergeTypes.BranchPolicyMergeTypesSettingsScope\"},\"kind\":\"array\"}}]}}")]
        object Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#allow_basic_no_fast_forward BranchPolicyMergeTypes#allow_basic_no_fast_forward}.</summary>
        [JsiiProperty(name: "allowBasicNoFastForward", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowBasicNoFastForward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#allow_rebase_and_fast_forward BranchPolicyMergeTypes#allow_rebase_and_fast_forward}.</summary>
        [JsiiProperty(name: "allowRebaseAndFastForward", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowRebaseAndFastForward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#allow_rebase_with_merge BranchPolicyMergeTypes#allow_rebase_with_merge}.</summary>
        [JsiiProperty(name: "allowRebaseWithMerge", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowRebaseWithMerge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#allow_squash BranchPolicyMergeTypes#allow_squash}.</summary>
        [JsiiProperty(name: "allowSquash", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowSquash
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyMergeTypesSettings), fullyQualifiedName: "azuredevops.branchPolicyMergeTypes.BranchPolicyMergeTypesSettings")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyMergeTypes.IBranchPolicyMergeTypesSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#scope BranchPolicyMergeTypes#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyMergeTypes.BranchPolicyMergeTypesSettingsScope\"},\"kind\":\"array\"}}]}}")]
            public object Scope
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#allow_basic_no_fast_forward BranchPolicyMergeTypes#allow_basic_no_fast_forward}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowBasicNoFastForward", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowBasicNoFastForward
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#allow_rebase_and_fast_forward BranchPolicyMergeTypes#allow_rebase_and_fast_forward}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowRebaseAndFastForward", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowRebaseAndFastForward
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#allow_rebase_with_merge BranchPolicyMergeTypes#allow_rebase_with_merge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowRebaseWithMerge", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowRebaseWithMerge
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_merge_types#allow_squash BranchPolicyMergeTypes#allow_squash}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowSquash", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowSquash
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
