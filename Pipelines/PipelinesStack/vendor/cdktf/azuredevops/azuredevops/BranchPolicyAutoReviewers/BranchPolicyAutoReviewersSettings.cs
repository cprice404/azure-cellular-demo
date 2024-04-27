using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyAutoReviewers
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.branchPolicyAutoReviewers.BranchPolicyAutoReviewersSettings")]
    public class BranchPolicyAutoReviewersSettings : azuredevops.BranchPolicyAutoReviewers.IBranchPolicyAutoReviewersSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#auto_reviewer_ids BranchPolicyAutoReviewers#auto_reviewer_ids}.</summary>
        [JsiiProperty(name: "autoReviewerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AutoReviewerIds
        {
            get;
            set;
        }

        private object _scope;

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#scope BranchPolicyAutoReviewers#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyAutoReviewers.BranchPolicyAutoReviewersSettingsScope\"},\"kind\":\"array\"}}]}}")]
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
                        case azuredevops.BranchPolicyAutoReviewers.IBranchPolicyAutoReviewersSettingsScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyAutoReviewers.IBranchPolicyAutoReviewersSettingsScope).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyAutoReviewers.IBranchPolicyAutoReviewersSettingsScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scope = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#message BranchPolicyAutoReviewers#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#minimum_number_of_reviewers BranchPolicyAutoReviewers#minimum_number_of_reviewers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumNumberOfReviewers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumNumberOfReviewers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#path_filters BranchPolicyAutoReviewers#path_filters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pathFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PathFilters
        {
            get;
            set;
        }

        private object? _submitterCanVote;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_auto_reviewers#submitter_can_vote BranchPolicyAutoReviewers#submitter_can_vote}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "submitterCanVote", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SubmitterCanVote
        {
            get => _submitterCanVote;
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
                _submitterCanVote = value;
            }
        }
    }
}
