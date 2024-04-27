using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyCommentResolution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettings")]
    public class BranchPolicyCommentResolutionSettings : azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettings
    {
        private object _scope;

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/branch_policy_comment_resolution#scope BranchPolicyCommentResolution#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyCommentResolution.BranchPolicyCommentResolutionSettingsScope\"},\"kind\":\"array\"}}]}}")]
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
                        case azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyCommentResolution.IBranchPolicyCommentResolutionSettingsScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scope = value;
            }
        }
    }
}
