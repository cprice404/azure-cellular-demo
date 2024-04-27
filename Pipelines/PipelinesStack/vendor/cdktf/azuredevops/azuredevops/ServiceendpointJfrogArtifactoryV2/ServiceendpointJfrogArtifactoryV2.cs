using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogArtifactoryV2
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_artifactory_v2 azuredevops_serviceendpoint_jfrog_artifactory_v2}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2), fullyQualifiedName: "azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2Config\"}}]")]
    public class ServiceendpointJfrogArtifactoryV2 : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_artifactory_v2 azuredevops_serviceendpoint_jfrog_artifactory_v2} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointJfrogArtifactoryV2(Constructs.Construct scope, string id, azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2Config config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2Config config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointJfrogArtifactoryV2(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointJfrogArtifactoryV2(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceendpointJfrogArtifactoryV2 resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointJfrogArtifactoryV2 to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointJfrogArtifactoryV2 that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointJfrogArtifactoryV2 to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointJfrogArtifactoryV2 to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_artifactory_v2#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointJfrogArtifactoryV2 that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointJfrogArtifactoryV2 to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthenticationBasic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationBasic\"}}]")]
        public virtual void PutAuthenticationBasic(azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationBasic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationBasic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthenticationToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationToken\"}}]")]
        public virtual void PutAuthenticationToken(azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2Timeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2Timeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2Timeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2))!;

        [JsiiProperty(name: "authenticationBasic", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationBasicOutputReference\"}")]
        public virtual azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationBasicOutputReference AuthenticationBasic
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationBasicOutputReference>()!;
        }

        [JsiiProperty(name: "authenticationToken", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationTokenOutputReference\"}")]
        public virtual azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationTokenOutputReference AuthenticationToken
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationTokenOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2TimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2TimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2TimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationBasicInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationBasic\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationBasic? AuthenticationBasicInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationBasic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationTokenInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationToken\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationToken? AuthenticationTokenInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationToken?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2Timeouts\"}]}}", isOptional: true)]
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
