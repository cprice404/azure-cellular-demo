using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArgocd
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd azuredevops_serviceendpoint_argocd}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointArgocd.ServiceendpointArgocd), fullyQualifiedName: "azuredevops.serviceendpointArgocd.ServiceendpointArgocd", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdConfig\"}}]")]
    public class ServiceendpointArgocd : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd azuredevops_serviceendpoint_argocd} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointArgocd(Constructs.Construct scope, string id, azuredevops.ServiceendpointArgocd.IServiceendpointArgocdConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointArgocd.IServiceendpointArgocdConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointArgocd(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointArgocd(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceendpointArgocd resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointArgocd to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointArgocd that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointArgocd to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointArgocd to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointArgocd that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointArgocd to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.ServiceendpointArgocd.ServiceendpointArgocd), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthenticationBasic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationBasic\"}}]")]
        public virtual void PutAuthenticationBasic(azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationBasic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationBasic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthenticationToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationToken\"}}]")]
        public virtual void PutAuthenticationToken(azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointArgocd.IServiceendpointArgocdTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointArgocd.IServiceendpointArgocdTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticationBasic")]
        public virtual void ResetAuthenticationBasic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthenticationToken")]
        public virtual void ResetAuthenticationToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
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
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointArgocd.ServiceendpointArgocd))!;

        [JsiiProperty(name: "authenticationBasic", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationBasicOutputReference\"}")]
        public virtual azuredevops.ServiceendpointArgocd.ServiceendpointArgocdAuthenticationBasicOutputReference AuthenticationBasic
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArgocd.ServiceendpointArgocdAuthenticationBasicOutputReference>()!;
        }

        [JsiiProperty(name: "authenticationToken", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationTokenOutputReference\"}")]
        public virtual azuredevops.ServiceendpointArgocd.ServiceendpointArgocdAuthenticationTokenOutputReference AuthenticationToken
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArgocd.ServiceendpointArgocdAuthenticationTokenOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointArgocd.ServiceendpointArgocdTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArgocd.ServiceendpointArgocdTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationBasicInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationBasic\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationBasic? AuthenticationBasicInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationBasic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationTokenInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationToken\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationToken? AuthenticationTokenInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationToken?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AuthorizationInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointArgocd.ServiceendpointArgocdTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Authorization
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
