using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyMinReviewers
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyMinReviewersSettings), fullyQualifiedName: "azuredevops.branchPolicyMinReviewers.BranchPolicyMinReviewersSettings")]
    public interface IBranchPolicyMinReviewersSettings
    {
        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#scope BranchPolicyMinReviewers#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyMinReviewers.BranchPolicyMinReviewersSettingsScope\"},\"kind\":\"array\"}}]}}")]
        object Scope
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#allow_completion_with_rejects_or_waits BranchPolicyMinReviewers#allow_completion_with_rejects_or_waits}.</summary>
        [JsiiProperty(name: "allowCompletionWithRejectsOrWaits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowCompletionWithRejectsOrWaits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#last_pusher_cannot_approve BranchPolicyMinReviewers#last_pusher_cannot_approve}.</summary>
        [JsiiProperty(name: "lastPusherCannotApprove", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastPusherCannotApprove
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#on_last_iteration_require_vote BranchPolicyMinReviewers#on_last_iteration_require_vote}.</summary>
        [JsiiProperty(name: "onLastIterationRequireVote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnLastIterationRequireVote
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#on_push_reset_all_votes BranchPolicyMinReviewers#on_push_reset_all_votes}.</summary>
        [JsiiProperty(name: "onPushResetAllVotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnPushResetAllVotes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#on_push_reset_approved_votes BranchPolicyMinReviewers#on_push_reset_approved_votes}.</summary>
        [JsiiProperty(name: "onPushResetApprovedVotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnPushResetApprovedVotes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#reviewer_count BranchPolicyMinReviewers#reviewer_count}.</summary>
        [JsiiProperty(name: "reviewerCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReviewerCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#submitter_can_vote BranchPolicyMinReviewers#submitter_can_vote}.</summary>
        [JsiiProperty(name: "submitterCanVote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubmitterCanVote
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyMinReviewersSettings), fullyQualifiedName: "azuredevops.branchPolicyMinReviewers.BranchPolicyMinReviewersSettings")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyMinReviewers.IBranchPolicyMinReviewersSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#scope BranchPolicyMinReviewers#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyMinReviewers.BranchPolicyMinReviewersSettingsScope\"},\"kind\":\"array\"}}]}}")]
            public object Scope
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#allow_completion_with_rejects_or_waits BranchPolicyMinReviewers#allow_completion_with_rejects_or_waits}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowCompletionWithRejectsOrWaits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowCompletionWithRejectsOrWaits
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#last_pusher_cannot_approve BranchPolicyMinReviewers#last_pusher_cannot_approve}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastPusherCannotApprove", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LastPusherCannotApprove
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#on_last_iteration_require_vote BranchPolicyMinReviewers#on_last_iteration_require_vote}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onLastIterationRequireVote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OnLastIterationRequireVote
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#on_push_reset_all_votes BranchPolicyMinReviewers#on_push_reset_all_votes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onPushResetAllVotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OnPushResetAllVotes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#on_push_reset_approved_votes BranchPolicyMinReviewers#on_push_reset_approved_votes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onPushResetApprovedVotes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OnPushResetApprovedVotes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#reviewer_count BranchPolicyMinReviewers#reviewer_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reviewerCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReviewerCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#submitter_can_vote BranchPolicyMinReviewers#submitter_can_vote}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "submitterCanVote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SubmitterCanVote
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
