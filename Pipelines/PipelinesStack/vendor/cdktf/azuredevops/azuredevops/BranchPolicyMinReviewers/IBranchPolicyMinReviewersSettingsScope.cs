using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyMinReviewers
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyMinReviewersSettingsScope), fullyQualifiedName: "azuredevops.branchPolicyMinReviewers.BranchPolicyMinReviewersSettingsScope")]
    public interface IBranchPolicyMinReviewersSettingsScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#match_type BranchPolicyMinReviewers#match_type}.</summary>
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#repository_id BranchPolicyMinReviewers#repository_id}.</summary>
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#repository_ref BranchPolicyMinReviewers#repository_ref}.</summary>
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryRef
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyMinReviewersSettingsScope), fullyQualifiedName: "azuredevops.branchPolicyMinReviewers.BranchPolicyMinReviewersSettingsScope")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyMinReviewers.IBranchPolicyMinReviewersSettingsScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#match_type BranchPolicyMinReviewers#match_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#repository_id BranchPolicyMinReviewers#repository_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_min_reviewers#repository_ref BranchPolicyMinReviewers#repository_ref}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryRef
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
