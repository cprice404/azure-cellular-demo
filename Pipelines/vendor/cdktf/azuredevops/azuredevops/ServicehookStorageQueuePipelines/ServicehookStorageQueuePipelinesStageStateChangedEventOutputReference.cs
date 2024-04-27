using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookStorageQueuePipelines
{
    [JsiiClass(nativeType: typeof(azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookStorageQueuePipelinesStageStateChangedEventOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPipelineId")]
        public virtual void ResetPipelineId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStageName")]
        public virtual void ResetStageName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStageResultFilter")]
        public virtual void ResetStageResultFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStageStateFilter")]
        public virtual void ResetStageStateFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StageNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageResultFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StageResultFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageStateFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StageStateFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StageName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stageResultFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StageResultFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stageStateFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StageStateFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEvent\"}", isOptional: true)]
        public virtual azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent?>();
            set => SetInstanceProperty(value);
        }
    }
}
