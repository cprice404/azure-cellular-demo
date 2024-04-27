using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointAzurerm
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/serviceendpoint_azurerm azuredevops_serviceendpoint_azurerm}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsServiceendpointAzurerm.DataAzuredevopsServiceendpointAzurerm), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointAzurerm.DataAzuredevopsServiceendpointAzurerm", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsServiceendpointAzurerm.DataAzuredevopsServiceendpointAzurermConfig\"}}]")]
    public class DataAzuredevopsServiceendpointAzurerm : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/serviceendpoint_azurerm azuredevops_serviceendpoint_azurerm} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzuredevopsServiceendpointAzurerm(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsServiceendpointAzurerm.IDataAzuredevopsServiceendpointAzurermConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsServiceendpointAzurerm.IDataAzuredevopsServiceendpointAzurermConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsServiceendpointAzurerm(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsServiceendpointAzurerm(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzuredevopsServiceendpointAzurerm resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzuredevopsServiceendpointAzurerm to import.</param>
        /// <param name="importFromId">The id of the existing DataAzuredevopsServiceendpointAzurerm that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzuredevopsServiceendpointAzurerm to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzuredevopsServiceendpointAzurerm to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/serviceendpoint_azurerm#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzuredevopsServiceendpointAzurerm that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzuredevopsServiceendpointAzurerm to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.DataAzuredevopsServiceendpointAzurerm.DataAzuredevopsServiceendpointAzurerm), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceEndpointId")]
        public virtual void ResetServiceEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceEndpointName")]
        public virtual void ResetServiceEndpointName()
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
        = GetStaticProperty<string>(typeof(azuredevops.DataAzuredevopsServiceendpointAzurerm.DataAzuredevopsServiceendpointAzurerm))!;

        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Authorization
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "azurermManagementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermManagementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azurermManagementGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermManagementGroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azurermSpnTenantid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermSpnTenantid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azurermSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermSubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azurermSubscriptionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzurermSubscriptionName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Environment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceEndpointAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceEndpointAuthenticationScheme
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "serviceEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceEndpointNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceEndpointNameInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "serviceEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceEndpointId
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
