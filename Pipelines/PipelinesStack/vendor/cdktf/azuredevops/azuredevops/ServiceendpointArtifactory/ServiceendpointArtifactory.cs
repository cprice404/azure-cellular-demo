using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArtifactory
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory azuredevops_serviceendpoint_artifactory}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactory), fullyQualifiedName: "azuredevops.serviceendpointArtifactory.ServiceendpointArtifactory", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryConfig\"}}]")]
    public class ServiceendpointArtifactory : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory azuredevops_serviceendpoint_artifactory} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointArtifactory(Constructs.Construct scope, string id, azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointArtifactory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointArtifactory(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceendpointArtifactory resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointArtifactory to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointArtifactory that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointArtifactory to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointArtifactory to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointArtifactory that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointArtifactory to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactory), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthenticationBasic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationBasic\"}}]")]
        public virtual void PutAuthenticationBasic(azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationBasic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationBasic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthenticationToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationToken\"}}]")]
        public virtual void PutAuthenticationToken(azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactory))!;

        [JsiiProperty(name: "authenticationBasic", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationBasicOutputReference\"}")]
        public virtual azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactoryAuthenticationBasicOutputReference AuthenticationBasic
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactoryAuthenticationBasicOutputReference>()!;
        }

        [JsiiProperty(name: "authenticationToken", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationTokenOutputReference\"}")]
        public virtual azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactoryAuthenticationTokenOutputReference AuthenticationToken
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactoryAuthenticationTokenOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactoryTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArtifactory.ServiceendpointArtifactoryTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationBasicInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationBasic\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationBasic? AuthenticationBasicInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationBasic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationTokenInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationToken\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationToken? AuthenticationTokenInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationToken?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryTimeouts\"}]}}", isOptional: true)]
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
