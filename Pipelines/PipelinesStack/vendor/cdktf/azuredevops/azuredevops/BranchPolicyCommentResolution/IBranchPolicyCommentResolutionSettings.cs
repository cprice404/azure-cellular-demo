using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyCommentResolution
{
    [JsiiInterface(nativeType: typeof(IBranchPolicyCommentResolutionSettings), fullyQualifiedName: "azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettings")]
    public interface IBranchPolicyCommentResolutionSettings
    {
        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_comment_resolution#scope BranchPolicyCommentResolution#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScope\"},\"kind\":\"array\"}}]}}")]
        object Scope
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBranchPolicyCommentResolutionSettings), fullyQualifiedName: "azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettings")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_comment_resolution#scope BranchPolicyCommentResolution#scope}
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScope\"},\"kind\":\"array\"}}]}}")]
            public object Scope
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
