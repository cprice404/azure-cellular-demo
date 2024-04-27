using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyCommentResolution
{
    [JsiiByValue(fqn: "azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScope")]
    public class BranchPolicyCommentResolutionSettingsScope : azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_comment_resolution#match_type BranchPolicyCommentResolution#match_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_comment_resolution#repository_id BranchPolicyCommentResolution#repository_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_comment_resolution#repository_ref BranchPolicyCommentResolution#repository_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryRef
        {
            get;
            set;
        }
    }
}
