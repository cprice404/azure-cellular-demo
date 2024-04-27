using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyWorkItemLinking
{
    [JsiiByValue(fqn: "azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScope")]
    public class BranchPolicyWorkItemLinkingSettingsScope : azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_work_item_linking#match_type BranchPolicyWorkItemLinking#match_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_work_item_linking#repository_id BranchPolicyWorkItemLinking#repository_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_work_item_linking#repository_ref BranchPolicyWorkItemLinking#repository_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryRef
        {
            get;
            set;
        }
    }
}
