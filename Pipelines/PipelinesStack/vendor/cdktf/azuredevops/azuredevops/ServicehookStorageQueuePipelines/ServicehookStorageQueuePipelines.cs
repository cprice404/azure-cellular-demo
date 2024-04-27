using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookStorageQueuePipelines
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines azuredevops_servicehook_storage_queue_pipelines}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelines), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelines", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesConfig\"}}]")]
    public class ServicehookStorageQueuePipelines : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines azuredevops_servicehook_storage_queue_pipelines} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServicehookStorageQueuePipelines(Constructs.Construct scope, string id, azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookStorageQueuePipelines(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookStorageQueuePipelines(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServicehookStorageQueuePipelines resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServicehookStorageQueuePipelines to import.</param>
        /// <param name="importFromId">The id of the existing ServicehookStorageQueuePipelines that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServicehookStorageQueuePipelines to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServicehookStorageQueuePipelines to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServicehookStorageQueuePipelines that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServicehookStorageQueuePipelines to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelines), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putRunStateChangedEvent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEvent\"}}]")]
        public virtual void PutRunStateChangedEvent(azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStageStateChangedEvent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEvent\"}}]")]
        public virtual void PutStageStateChangedEvent(azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunStateChangedEvent")]
        public virtual void ResetRunStateChangedEvent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStageStateChangedEvent")]
        public virtual void ResetStageStateChangedEvent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTtl")]
        public virtual void ResetTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVisiTimeout")]
        public virtual void ResetVisiTimeout()
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
        = GetStaticProperty<string>(typeof(azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelines))!;

        [JsiiProperty(name: "runStateChangedEvent", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference\"}")]
        public virtual azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference RunStateChangedEvent
        {
            get => GetInstanceProperty<azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference>()!;
        }

        [JsiiProperty(name: "stageStateChangedEvent", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference\"}")]
        public virtual azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference StageStateChangedEvent
        {
            get => GetInstanceProperty<azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNameInput
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
        [JsiiProperty(name: "queueNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueueNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runStateChangedEventInput", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEvent\"}", isOptional: true)]
        public virtual azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent? RunStateChangedEventInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageStateChangedEventInput", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEvent\"}", isOptional: true)]
        public virtual azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent? StageStateChangedEventInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "visiTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VisiTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
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

        [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "visiTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VisiTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
