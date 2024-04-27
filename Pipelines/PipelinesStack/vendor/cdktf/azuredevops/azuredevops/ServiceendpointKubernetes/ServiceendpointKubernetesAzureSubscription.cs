using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesAzureSubscription")]
    public class ServiceendpointKubernetesAzureSubscription : azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesAzureSubscription
    {
        /// <summary>name of aks-resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_name ServiceendpointKubernetes#cluster_name}
        /// </remarks>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterName
        {
            get;
            set;
        }

        /// <summary>id of resourcegroup.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#resourcegroup_id ServiceendpointKubernetes#resourcegroup_id}
        /// </remarks>
        [JsiiProperty(name: "resourcegroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourcegroupId
        {
            get;
            set;
        }

        /// <summary>id of azure subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#subscription_id ServiceendpointKubernetes#subscription_id}
        /// </remarks>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubscriptionId
        {
            get;
            set;
        }

        /// <summary>name of azure subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#subscription_name ServiceendpointKubernetes#subscription_name}
        /// </remarks>
        [JsiiProperty(name: "subscriptionName", typeJson: "{\"primitive\":\"string\"}")]
        public string SubscriptionName
        {
            get;
            set;
        }

        /// <summary>id of aad-tenant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#tenant_id ServiceendpointKubernetes#tenant_id}
        /// </remarks>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantId
        {
            get;
            set;
        }

        /// <summary>type of azure cloud: AzureCloud.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#azure_environment ServiceendpointKubernetes#azure_environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureEnvironment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzureEnvironment
        {
            get;
            set;
        }

        private object? _clusterAdmin;

        /// <summary>Enable Cluster Admin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_admin ServiceendpointKubernetes#cluster_admin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterAdmin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ClusterAdmin
        {
            get => _clusterAdmin;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clusterAdmin = value;
            }
        }

        /// <summary>accessed namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#namespace ServiceendpointKubernetes#namespace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }
    }
}
