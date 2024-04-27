using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiClass(nativeType: typeof(azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerOutputReference), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BuildDefinitionPullRequestTriggerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BuildDefinitionPullRequestTriggerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BuildDefinitionPullRequestTriggerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BuildDefinitionPullRequestTriggerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putForks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerForks\"}}]")]
        public virtual void PutForks(azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerForks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerForks)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverride\"}}]")]
        public virtual void PutOverride(azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCommentRequired")]
        public virtual void ResetCommentRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialBranch")]
        public virtual void ResetInitialBranch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverride")]
        public virtual void ResetOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUseYaml")]
        public virtual void ResetUseYaml()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "forks", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerForksOutputReference\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerForksOutputReference Forks
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerForksOutputReference>()!;
        }

        [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverrideOutputReference\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerOverrideOutputReference Override
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerOverrideOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentRequiredInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentRequiredInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forksInput", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerForks\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerForks? ForksInput
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerForks?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialBranchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InitialBranchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideInput", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOverride\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride? OverrideInput
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionPullRequestTriggerOverride?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "useYamlInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UseYamlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "commentRequired", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommentRequired
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialBranch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialBranch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "useYaml", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object UseYaml
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger? InternalValue
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger?>();
            set => SetInstanceProperty(value);
        }
    }
}
