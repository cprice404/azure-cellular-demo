using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyAutoReviewers
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyAutoReviewersSettings), fullyQualifiedName: "azuredevops.branchPolicyAutoReviewers.BranchPolicyAutoReviewersSettings")]
    public interface IBranchPolicyAutoReviewersSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#auto_reviewer_ids BranchPolicyAutoReviewers#auto_reviewer_ids}.</summary>
        [JsiiProperty(name: "autoReviewerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AutoReviewerIds
        {
            get;
        }

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#scope BranchPolicyAutoReviewers#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyAutoReviewers.BranchPolicyAutoReviewersSettingsScope\"},\"kind\":\"array\"}}]}}")]
        object Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#message BranchPolicyAutoReviewers#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#minimum_number_of_reviewers BranchPolicyAutoReviewers#minimum_number_of_reviewers}.</summary>
        [JsiiProperty(name: "minimumNumberOfReviewers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumNumberOfReviewers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#path_filters BranchPolicyAutoReviewers#path_filters}.</summary>
        [JsiiProperty(name: "pathFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PathFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#submitter_can_vote BranchPolicyAutoReviewers#submitter_can_vote}.</summary>
        [JsiiProperty(name: "submitterCanVote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubmitterCanVote
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyAutoReviewersSettings), fullyQualifiedName: "azuredevops.branchPolicyAutoReviewers.BranchPolicyAutoReviewersSettings")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyAutoReviewers.IBranchPolicyAutoReviewersSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#auto_reviewer_ids BranchPolicyAutoReviewers#auto_reviewer_ids}.</summary>
            [JsiiProperty(name: "autoReviewerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AutoReviewerIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#scope BranchPolicyAutoReviewers#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyAutoReviewers.BranchPolicyAutoReviewersSettingsScope\"},\"kind\":\"array\"}}]}}")]
            public object Scope
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#message BranchPolicyAutoReviewers#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#minimum_number_of_reviewers BranchPolicyAutoReviewers#minimum_number_of_reviewers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumNumberOfReviewers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumNumberOfReviewers
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#path_filters BranchPolicyAutoReviewers#path_filters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pathFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PathFilters
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#submitter_can_vote BranchPolicyAutoReviewers#submitter_can_vote}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "submitterCanVote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SubmitterCanVote
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
