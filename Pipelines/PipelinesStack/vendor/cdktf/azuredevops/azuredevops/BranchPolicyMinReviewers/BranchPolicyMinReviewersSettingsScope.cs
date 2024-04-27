using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyMinReviewers
{
    [JsiiByValue(fqn: "azuredevops.branchPolicyMinReviewers.BranchPolicyMinReviewersSettingsScope")]
    public class BranchPolicyMinReviewersSettingsScope : azuredevops.BranchPolicyMinReviewers.IBranchPolicyMinReviewersSettingsScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#match_type BranchPolicyMinReviewers#match_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#repository_id BranchPolicyMinReviewers#repository_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#repository_ref BranchPolicyMinReviewers#repository_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryRef
        {
            get;
            set;
        }
    }
}
