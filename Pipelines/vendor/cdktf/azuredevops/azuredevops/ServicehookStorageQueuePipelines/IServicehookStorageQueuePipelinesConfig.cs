using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookStorageQueuePipelines
{
    [JsiiInterface(nativeType: typeof(IServicehookStorageQueuePipelinesConfig), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesConfig")]
    public interface IServicehookStorageQueuePipelinesConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>A valid account key from the queue's storage account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#account_key ServicehookStorageQueuePipelines#account_key}
        /// </remarks>
        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
        string AccountKey
        {
            get;
        }

        /// <summary>The queue's storage account name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#account_name ServicehookStorageQueuePipelines#account_name}
        /// </remarks>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        string AccountName
        {
            get;
        }

        /// <summary>The ID of the project.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#project_id ServicehookStorageQueuePipelines#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>The name of the queue that will store the events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#queue_name ServicehookStorageQueuePipelines#queue_name}
        /// </remarks>
        [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}")]
        string QueueName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#id ServicehookStorageQueuePipelines#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_state_changed_event block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#run_state_changed_event ServicehookStorageQueuePipelines#run_state_changed_event}
        /// </remarks>
        [JsiiProperty(name: "runStateChangedEvent", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEvent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent? RunStateChangedEvent
        {
            get
            {
                return null;
            }
        }

        /// <summary>stage_state_changed_event block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#stage_state_changed_event ServicehookStorageQueuePipelines#stage_state_changed_event}
        /// </remarks>
        [JsiiProperty(name: "stageStateChangedEvent", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEvent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent? StageStateChangedEvent
        {
            get
            {
                return null;
            }
        }

        /// <summary>event time-to-live - the duration a message can remain in the queue before it's automatically removed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#ttl ServicehookStorageQueuePipelines#ttl}
        /// </remarks>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ttl
        {
            get
            {
                return null;
            }
        }

        /// <summary>event visibility timout - how long a message is invisible to other consumers after it's been dequeued.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#visi_timeout ServicehookStorageQueuePipelines#visi_timeout}
        /// </remarks>
        [JsiiProperty(name: "visiTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VisiTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicehookStorageQueuePipelinesConfig), fullyQualifiedName: "azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A valid account key from the queue's storage account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#account_key ServicehookStorageQueuePipelines#account_key}
            /// </remarks>
            [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The queue's storage account name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#account_name ServicehookStorageQueuePipelines#account_name}
            /// </remarks>
            [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the project.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#project_id ServicehookStorageQueuePipelines#project_id}
            /// </remarks>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the queue that will store the events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#queue_name ServicehookStorageQueuePipelines#queue_name}
            /// </remarks>
            [JsiiProperty(name: "queueName", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#id ServicehookStorageQueuePipelines#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>run_state_changed_event block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#run_state_changed_event ServicehookStorageQueuePipelines#run_state_changed_event}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runStateChangedEvent", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesRunStateChangedEvent\"}", isOptional: true)]
            public azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent? RunStateChangedEvent
            {
                get => GetInstanceProperty<azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesRunStateChangedEvent?>();
            }

            /// <summary>stage_state_changed_event block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#stage_state_changed_event ServicehookStorageQueuePipelines#stage_state_changed_event}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stageStateChangedEvent", typeJson: "{\"fqn\":\"azuredevops.servicehookStorageQueuePipelines.ServicehookStorageQueuePipelinesStageStateChangedEvent\"}", isOptional: true)]
            public azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent? StageStateChangedEvent
            {
                get => GetInstanceProperty<azuredevops.ServicehookStorageQueuePipelines.IServicehookStorageQueuePipelinesStageStateChangedEvent?>();
            }

            /// <summary>event time-to-live - the duration a message can remain in the queue before it's automatically removed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#ttl ServicehookStorageQueuePipelines#ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ttl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>event visibility timout - how long a message is invisible to other consumers after it's been dequeued.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/servicehook_storage_queue_pipelines#visi_timeout ServicehookStorageQueuePipelines#visi_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "visiTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VisiTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
