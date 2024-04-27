using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyStatusCheck
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyStatusCheckSettings), fullyQualifiedName: "azuredevops.branchPolicyStatusCheck.BranchPolicyStatusCheckSettings")]
    public interface IBranchPolicyStatusCheckSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#name BranchPolicyStatusCheck#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#scope BranchPolicyStatusCheck#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyStatusCheck.BranchPolicyStatusCheckSettingsScope\"},\"kind\":\"array\"}}]}}")]
        object Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#applicability BranchPolicyStatusCheck#applicability}.</summary>
        [JsiiProperty(name: "applicability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Applicability
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#author_id BranchPolicyStatusCheck#author_id}.</summary>
        [JsiiProperty(name: "authorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#display_name BranchPolicyStatusCheck#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#filename_patterns BranchPolicyStatusCheck#filename_patterns}.</summary>
        [JsiiProperty(name: "filenamePatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FilenamePatterns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#genre BranchPolicyStatusCheck#genre}.</summary>
        [JsiiProperty(name: "genre", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Genre
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#invalidate_on_update BranchPolicyStatusCheck#invalidate_on_update}.</summary>
        [JsiiProperty(name: "invalidateOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InvalidateOnUpdate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyStatusCheckSettings), fullyQualifiedName: "azuredevops.branchPolicyStatusCheck.BranchPolicyStatusCheckSettings")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyStatusCheck.IBranchPolicyStatusCheckSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#name BranchPolicyStatusCheck#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#scope BranchPolicyStatusCheck#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyStatusCheck.BranchPolicyStatusCheckSettingsScope\"},\"kind\":\"array\"}}]}}")]
            public object Scope
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#applicability BranchPolicyStatusCheck#applicability}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Applicability
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#author_id BranchPolicyStatusCheck#author_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#display_name BranchPolicyStatusCheck#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#filename_patterns BranchPolicyStatusCheck#filename_patterns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filenamePatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FilenamePatterns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#genre BranchPolicyStatusCheck#genre}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "genre", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Genre
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#invalidate_on_update BranchPolicyStatusCheck#invalidate_on_update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invalidateOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InvalidateOnUpdate
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
