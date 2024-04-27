using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiClass(nativeType: typeof(azuredevops.BuildDefinition.BuildDefinitionCiTriggerOutputReference), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionCiTriggerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BuildDefinitionCiTriggerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BuildDefinitionCiTriggerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BuildDefinitionCiTriggerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BuildDefinitionCiTriggerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverride\"}}]")]
        public virtual void PutOverride(azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride)}, new object[]{@value});
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

        [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverrideOutputReference\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionCiTriggerOverrideOutputReference Override
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionCiTriggerOverrideOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideInput", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverride\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride? OverrideInput
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "useYamlInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UseYamlInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTrigger\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionCiTrigger? InternalValue
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionCiTrigger?>();
            set => SetInstanceProperty(value);
        }
    }
}
