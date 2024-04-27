using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookStorageQueuePipelines
{
    [JsiiClass(nativeType: typeof(azuredevops.ServicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookStorageQueuePipelinesRunStateChangedEventOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPipelineId")]
        public virtual void ResetPipelineId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunResultFilter")]
        public virtual void ResetRunResultFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunStateFilter")]
        public virtual void ResetRunStateFilter()
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
        [JsiiProperty(name: "runResultFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunResultFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runStateFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunStateFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runResultFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunResultFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runStateFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunStateFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEvent\"}", isOptional: true)]
        public virtual azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent?>();
            set => SetInstanceProperty(value);
        }
    }
}
