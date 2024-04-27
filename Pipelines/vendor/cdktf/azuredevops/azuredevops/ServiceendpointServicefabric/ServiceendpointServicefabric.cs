using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointServicefabric
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric azuredevops_serviceendpoint_servicefabric}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabric), fullyQualifiedName: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabric", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricConfig\"}}]")]
    public class ServiceendpointServicefabric : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric azuredevops_serviceendpoint_servicefabric} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointServicefabric(Constructs.Construct scope, string id, azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointServicefabric(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointServicefabric(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceendpointServicefabric resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointServicefabric to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointServicefabric that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointServicefabric to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointServicefabric to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointServicefabric that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointServicefabric to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabric), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectory\"}}]")]
        public virtual void PutAzureActiveDirectory(azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricCertificate\"}}]")]
        public virtual void PutCertificate(azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricNone\"}}]")]
        public virtual void PutNone(azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureActiveDirectory")]
        public virtual void ResetAzureActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNone")]
        public virtual void ResetNone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabric))!;

        [JsiiProperty(name: "azureActiveDirectory", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectoryOutputReference\"}")]
        public virtual azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectoryOutputReference AzureActiveDirectory
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricCertificateOutputReference\"}")]
        public virtual azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricNoneOutputReference\"}")]
        public virtual azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricNoneOutputReference None
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricNoneOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.ServiceendpointServicefabricTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AuthorizationInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureActiveDirectoryInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectory\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory? AzureActiveDirectoryInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricCertificate\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate? CertificateInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noneInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricNone\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone? NoneInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceEndpointNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceEndpointNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Authorization
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceEndpointName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
