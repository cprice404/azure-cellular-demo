using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzuredevops
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azuredevops azuredevops_serviceendpoint_azuredevops}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointAzuredevops.ServiceendpointAzuredevops), fullyQualifiedName: "azuredevops.serviceendpointAzuredevops.ServiceendpointAzuredevops", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointAzuredevops.ServiceendpointAzuredevopsConfig\"}}]")]
    public class ServiceendpointAzuredevops : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azuredevops azuredevops_serviceendpoint_azuredevops} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointAzuredevops(Constructs.Construct scope, string id, azuredevops.ServiceendpointAzuredevops.IServiceendpointAzuredevopsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointAzuredevops.IServiceendpointAzuredevopsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointAzuredevops(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointAzuredevops(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceendpointAzuredevops resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointAzuredevops to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointAzuredevops that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointAzuredevops to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointAzuredevops to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azuredevops#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointAzuredevops that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointAzuredevops to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.ServiceendpointAzuredevops.ServiceendpointAzuredevops), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointAzuredevops.ServiceendpointAzuredevopsTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointAzuredevops.IServiceendpointAzuredevopsTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointAzuredevops.IServiceendpointAzuredevopsTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetOrgUrl")]
        public virtual void ResetOrgUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReleaseApiUrl")]
        public virtual void ResetReleaseApiUrl()
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
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointAzuredevops.ServiceendpointAzuredevops))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzuredevops.ServiceendpointAzuredevopsTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointAzuredevops.ServiceendpointAzuredevopsTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointAzuredevops.ServiceendpointAzuredevopsTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "orgUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrgUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "personalAccessTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersonalAccessTokenInput
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
        [JsiiProperty(name: "releaseApiUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseApiUrlInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointAzuredevops.ServiceendpointAzuredevopsTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "orgUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrgUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersonalAccessToken
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

        [JsiiProperty(name: "releaseApiUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseApiUrl
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
