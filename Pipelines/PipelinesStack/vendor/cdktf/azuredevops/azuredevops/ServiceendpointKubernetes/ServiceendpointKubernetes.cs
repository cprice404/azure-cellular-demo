using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes azuredevops_serviceendpoint_kubernetes}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetes), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetes", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesConfig\"}}]")]
    public class ServiceendpointKubernetes : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes azuredevops_serviceendpoint_kubernetes} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointKubernetes(Constructs.Construct scope, string id, azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointKubernetes(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointKubernetes(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceendpointKubernetes resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointKubernetes to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointKubernetes that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointKubernetes to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointKubernetes to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointKubernetes that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointKubernetes to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetes), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureSubscription", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesAzureSubscription\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAzureSubscription(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesAzureSubscription[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesAzureSubscription).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesAzureSubscription).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKubeconfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesKubeconfig\"}}]")]
        public virtual void PutKubeconfig(azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccount\"}}]")]
        public virtual void PutServiceAccount(azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureSubscription")]
        public virtual void ResetAzureSubscription()
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

        [JsiiMethod(name: "resetKubeconfig")]
        public virtual void ResetKubeconfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceAccount")]
        public virtual void ResetServiceAccount()
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
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetes))!;

        [JsiiProperty(name: "azureSubscription", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesAzureSubscriptionList\"}")]
        public virtual azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetesAzureSubscriptionList AzureSubscription
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetesAzureSubscriptionList>()!;
        }

        [JsiiProperty(name: "kubeconfig", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesKubeconfigOutputReference\"}")]
        public virtual azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetesKubeconfigOutputReference Kubeconfig
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetesKubeconfigOutputReference>()!;
        }

        [JsiiProperty(name: "serviceAccount", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccountOutputReference\"}")]
        public virtual azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetesServiceAccountOutputReference ServiceAccount
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetesServiceAccountOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.ServiceendpointKubernetesTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiserverUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiserverUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AuthorizationInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureSubscriptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesAzureSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AzureSubscriptionInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "kubeconfigInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesKubeconfig\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig? KubeconfigInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccount\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount? ServiceAccountInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceEndpointNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceEndpointNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "apiserverUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiserverUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Authorization
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationType
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
