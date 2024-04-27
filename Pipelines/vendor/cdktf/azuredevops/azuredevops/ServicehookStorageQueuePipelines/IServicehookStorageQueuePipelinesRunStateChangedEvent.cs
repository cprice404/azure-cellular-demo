using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookStorageQueuePipelines
{
    [JsiiInterface(nativeType: typeof(IServicehookStorageQueuePipelinesRunStateChangedEvent), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEvent")]
    public interface IServicehookStorageQueuePipelinesRunStateChangedEvent
    {
        /// <summary>The pipeline ID to be monitored. If not specified, all pipelines in the project will trigger the event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#pipeline_id ServicehookStorageQueuePipelines#pipeline_id}
        /// </remarks>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which run result should generate an event.</summary>
        /// <remarks>
        /// Only valid if published_event is <c>RunStateChanged</c>. If not specified, all results will trigger the event
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#run_result_filter ServicehookStorageQueuePipelines#run_result_filter}
        /// </remarks>
        [JsiiProperty(name: "runResultFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RunResultFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which run state should generate an event.</summary>
        /// <remarks>
        /// Only valid if published_event is <c>RunStateChanged</c>. If not specified, all states will trigger the event
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#run_state_filter ServicehookStorageQueuePipelines#run_state_filter}
        /// </remarks>
        [JsiiProperty(name: "runStateFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RunStateFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicehookStorageQueuePipelinesRunStateChangedEvent), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEvent")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The pipeline ID to be monitored. If not specified, all pipelines in the project will trigger the event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#pipeline_id ServicehookStorageQueuePipelines#pipeline_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Which run result should generate an event.</summary>
            /// <remarks>
            /// Only valid if published_event is <c>RunStateChanged</c>. If not specified, all results will trigger the event
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#run_result_filter ServicehookStorageQueuePipelines#run_result_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runResultFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunResultFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Which run state should generate an event.</summary>
            /// <remarks>
            /// Only valid if published_event is <c>RunStateChanged</c>. If not specified, all states will trigger the event
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#run_state_filter ServicehookStorageQueuePipelines#run_state_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runStateFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunStateFilter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
