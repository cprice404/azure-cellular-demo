using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookStorageQueuePipelines
{
    [JsiiInterface(nativeType: typeof(IServicehookStorageQueuePipelinesStageStateChangedEvent), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEvent")]
    public interface IServicehookStorageQueuePipelinesStageStateChangedEvent
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

        /// <summary>Which stage should generate an event.</summary>
        /// <remarks>
        /// Only valid if published_event is <c>StageStateChanged</c>. If not specified, all stages will trigger the event
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#stage_name ServicehookStorageQueuePipelines#stage_name}
        /// </remarks>
        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StageName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which stage result should generate an event.</summary>
        /// <remarks>
        /// Only valid if published_event is <c>StageStateChanged</c>. If not specified, all results will trigger the event
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#stage_result_filter ServicehookStorageQueuePipelines#stage_result_filter}
        /// </remarks>
        [JsiiProperty(name: "stageResultFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StageResultFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Which stage state should generate an event.</summary>
        /// <remarks>
        /// Only valid if published_event is <c>StageStateChanged</c>. If not specified, all states will trigger the event
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#stage_state_filter ServicehookStorageQueuePipelines#stage_state_filter}
        /// </remarks>
        [JsiiProperty(name: "stageStateFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StageStateFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicehookStorageQueuePipelinesStageStateChangedEvent), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEvent")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent
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

            /// <summary>Which stage should generate an event.</summary>
            /// <remarks>
            /// Only valid if published_event is <c>StageStateChanged</c>. If not specified, all stages will trigger the event
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#stage_name ServicehookStorageQueuePipelines#stage_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StageName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Which stage result should generate an event.</summary>
            /// <remarks>
            /// Only valid if published_event is <c>StageStateChanged</c>. If not specified, all results will trigger the event
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#stage_result_filter ServicehookStorageQueuePipelines#stage_result_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stageResultFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StageResultFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Which stage state should generate an event.</summary>
            /// <remarks>
            /// Only valid if published_event is <c>StageStateChanged</c>. If not specified, all states will trigger the event
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#stage_state_filter ServicehookStorageQueuePipelines#stage_state_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stageStateFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StageStateFilter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
