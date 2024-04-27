using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyStatusCheck
{
    [JsiiByValue(fqn: "azuredevops.branchPolicyStatusCheck.BranchPolicyStatusCheckSettingsScope")]
    public class BranchPolicyStatusCheckSettingsScope : azuredevops.BranchPolicyStatusCheck.IBranchPolicyStatusCheckSettingsScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#match_type BranchPolicyStatusCheck#match_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#repository_id BranchPolicyStatusCheck#repository_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_status_check#repository_ref BranchPolicyStatusCheck#repository_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryRef
        {
            get;
            set;
        }
    }
}
