using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurerm
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm azuredevops_serviceendpoint_azurerm}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointAzurerm.ServiceendpointAzurerm), fullyQualifiedName: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurerm", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermConfig\"}}]")]
    public class ServiceendpointAzurerm : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm azuredevops_serviceendpoint_azurerm} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointAzurerm(Constructs.Construct scope, string id, azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointAzurerm(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointAzurerm(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceendpointAzurerm resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointAzurerm to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointAzurerm that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointAzurerm to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointAzurerm to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointAzurerm that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointAzurerm to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.ServiceendpointAzurerm.ServiceendpointAzurerm), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentials\"}}]")]
        public virtual void PutCredentials(azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFeatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermFeatures\"}}]")]
        public virtual void PutFeatures(azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzurermManagementGroupId")]
        public virtual void ResetAzurermManagementGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzurermManagementGroupName")]
        public virtual void ResetAzurermManagementGroupName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzurermSubscriptionId")]
        public virtual void ResetAzurermSubscriptionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzurermSubscriptionName")]
        public virtual void ResetAzurermSubscriptionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatures")]
        public virtual void ResetFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceGroup")]
        public virtual void ResetResourceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceEndpointAuthenticationScheme")]
        public virtual void ResetServiceEndpointAuthenticationScheme()
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
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointAzurerm.ServiceendpointAzurerm))!;

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentialsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointAzurerm.ServiceendpointAzurermCredentialsOutputReference Credentials
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.ServiceendpointAzurermCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermFeaturesOutputReference\"}")]
        public virtual azuredevops.ServiceendpointAzurerm.ServiceendpointAzurermFeaturesOutputReference Features
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.ServiceendpointAzurermFeaturesOutputReference>()!;
        }

        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePrincipalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointAzurerm.ServiceendpointAzurermTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.ServiceendpointAzurermTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workloadIdentityFederationIssuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadIdentityFederationIssuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workloadIdentityFederationSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadIdentityFederationSubject
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AuthorizationInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azurermManagementGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzurermManagementGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azurermManagementGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzurermManagementGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azurermSpnTenantidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzurermSpnTenantidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azurermSubscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzurermSubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azurermSubscriptionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AzurermSubscriptionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentials\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials? CredentialsInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermFeatures\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures? FeaturesInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures?>();
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
        [JsiiProperty(name: "resourceGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceEndpointAuthenticationSchemeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceEndpointAuthenticationSchemeInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "azurermManagementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermManagementGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azurermManagementGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermManagementGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azurermSpnTenantid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermSpnTenantid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azurermSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermSubscriptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "azurermSubscriptionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermSubscriptionName
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

        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Environment
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

        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceEndpointAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceEndpointAuthenticationScheme
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
