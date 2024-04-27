using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurerm
{
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointAzurerm.ServiceendpointAzurermCredentialsOutputReference), fullyQualifiedName: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceendpointAzurermCredentialsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceendpointAzurermCredentialsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServiceendpointAzurermCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointAzurermCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetServiceprincipalkey")]
        public virtual void ResetServiceprincipalkey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceprincipalidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceprincipalidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceprincipalkeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceprincipalkeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "serviceprincipalid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Serviceprincipalid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceprincipalkey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Serviceprincipalkey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentials\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
