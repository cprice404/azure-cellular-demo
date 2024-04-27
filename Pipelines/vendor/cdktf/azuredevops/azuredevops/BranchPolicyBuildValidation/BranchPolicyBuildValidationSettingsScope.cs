using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyBuildValidation
{
    [JsiiByValue(fqn: "azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettingsScope")]
    public class BranchPolicyBuildValidationSettingsScope : azuredevops.BranchPolicyBuildValidation.IBranchPolicyBuildValidationSettingsScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#match_type BranchPolicyBuildValidation#match_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#repository_id BranchPolicyBuildValidation#repository_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#repository_ref BranchPolicyBuildValidation#repository_ref}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryRef
        {
            get;
            set;
        }
    }
}
