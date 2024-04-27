using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyBuildValidation
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyBuildValidationSettingsScope), fullyQualifiedName: "azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettingsScope")]
    public interface IBranchPolicyBuildValidationSettingsScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#match_type BranchPolicyBuildValidation#match_type}.</summary>
        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#repository_id BranchPolicyBuildValidation#repository_id}.</summary>
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#repository_ref BranchPolicyBuildValidation#repository_ref}.</summary>
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryRef
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyBuildValidationSettingsScope), fullyQualifiedName: "azuredevops.branchPolicyBuildValidation.BranchPolicyBuildValidationSettingsScope")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyBuildValidation.IBranchPolicyBuildValidationSettingsScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#match_type BranchPolicyBuildValidation#match_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#repository_id BranchPolicyBuildValidation#repository_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_build_validation#repository_ref BranchPolicyBuildValidation#repository_ref}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryRef
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
