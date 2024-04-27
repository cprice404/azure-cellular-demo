using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    [JsiiInterface(nativeType: typeof(IServiceendpointKubernetesAzureSubscription), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesAzureSubscription")]
    public interface IServiceendpointKubernetesAzureSubscription
    {
        /// <summary>name of aks-resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_name ServiceendpointKubernetes#cluster_name}
        /// </remarks>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterName
        {
            get;
        }

        /// <summary>id of resourcegroup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#resourcegroup_id ServiceendpointKubernetes#resourcegroup_id}
        /// </remarks>
        [JsiiProperty(name: "resourcegroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourcegroupId
        {
            get;
        }

        /// <summary>id of azure subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#subscription_id ServiceendpointKubernetes#subscription_id}
        /// </remarks>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        string SubscriptionId
        {
            get;
        }

        /// <summary>name of azure subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#subscription_name ServiceendpointKubernetes#subscription_name}
        /// </remarks>
        [JsiiProperty(name: "subscriptionName", typeJson: "{\"primitive\":\"string\"}")]
        string SubscriptionName
        {
            get;
        }

        /// <summary>id of aad-tenant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#tenant_id ServiceendpointKubernetes#tenant_id}
        /// </remarks>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        string TenantId
        {
            get;
        }

        /// <summary>type of azure cloud: AzureCloud.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#azure_environment ServiceendpointKubernetes#azure_environment}
        /// </remarks>
        [JsiiProperty(name: "azureEnvironment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzureEnvironment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable Cluster Admin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_admin ServiceendpointKubernetes#cluster_admin}
        /// </remarks>
        [JsiiProperty(name: "clusterAdmin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClusterAdmin
        {
            get
            {
                return null;
            }
        }

        /// <summary>accessed namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#namespace ServiceendpointKubernetes#namespace}
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointKubernetesAzureSubscription), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesAzureSubscription")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesAzureSubscription
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>name of aks-resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_name ServiceendpointKubernetes#cluster_name}
            /// </remarks>
            [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>id of resourcegroup.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#resourcegroup_id ServiceendpointKubernetes#resourcegroup_id}
            /// </remarks>
            [JsiiProperty(name: "resourcegroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourcegroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>id of azure subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#subscription_id ServiceendpointKubernetes#subscription_id}
            /// </remarks>
            [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubscriptionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>name of azure subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#subscription_name ServiceendpointKubernetes#subscription_name}
            /// </remarks>
            [JsiiProperty(name: "subscriptionName", typeJson: "{\"primitive\":\"string\"}")]
            public string SubscriptionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>id of aad-tenant.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#tenant_id ServiceendpointKubernetes#tenant_id}
            /// </remarks>
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>type of azure cloud: AzureCloud.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#azure_environment ServiceendpointKubernetes#azure_environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureEnvironment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzureEnvironment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable Cluster Admin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_admin ServiceendpointKubernetes#cluster_admin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterAdmin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ClusterAdmin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>accessed namespace.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#namespace ServiceendpointKubernetes#namespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
