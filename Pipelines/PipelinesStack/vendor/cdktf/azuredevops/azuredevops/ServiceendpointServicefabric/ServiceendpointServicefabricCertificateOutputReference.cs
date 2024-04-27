using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointServicefabric
{
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricCertificateOutputReference), fullyQualifiedName: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricCertificateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceendpointServicefabricCertificateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceendpointServicefabricCertificateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServiceendpointServicefabricCertificateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointServicefabricCertificateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClientCertificatePassword")]
        public virtual void ResetClientCertificatePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerCertificateCommonName")]
        public virtual void ResetServerCertificateCommonName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerCertificateThumbprint")]
        public virtual void ResetServerCertificateThumbprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificatePasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificatePasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverCertificateCommonNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerCertificateCommonNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverCertificateLookupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerCertificateLookupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverCertificateThumbprintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerCertificateThumbprintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificatePassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverCertificateCommonName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerCertificateCommonName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverCertificateLookup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerCertificateLookup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerCertificateThumbprint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricCertificate\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate?>();
            set => SetInstanceProperty(value);
        }
    }
}
