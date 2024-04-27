using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BranchPolicyWorkItemLinking
{
    [JsiiClass(nativeType: typeof(azuredevops.BranchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsOutputReference), fullyQualifiedName: "azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BranchPolicyWorkItemLinkingSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BranchPolicyWorkItemLinkingSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BranchPolicyWorkItemLinkingSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BranchPolicyWorkItemLinkingSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScope", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScope\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScope(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettingsScope).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScopeList\"}")]
        public virtual azuredevops.BranchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScopeList Scope
        {
            get => GetInstanceProperty<azuredevops.BranchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScopeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettingsScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScopeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.branchPolicyWorkItemLinking.BranchPolicyWorkItemLinkingSettings\"}", isOptional: true)]
        public virtual azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettings? InternalValue
        {
            get => GetInstanceProperty<azuredevops.BranchPolicyWorkItemLinking.IBranchPolicyWorkItemLinkingSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
