using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesKubeconfig")]
    public class ServiceendpointKubernetesKubeconfig : azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig
    {
        /// <summary>Content of the kubeconfig file.</summary>
        /// <remarks>
        /// The configuration information in your kubeconfig file allows Kubernetes clients to talk to your Kubernetes API servers. This file is used by kubectl and all supported Kubernetes clients.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#kube_config ServiceendpointKubernetes#kube_config}
        /// </remarks>
        [JsiiProperty(name: "kubeConfig", typeJson: "{\"primitive\":\"string\"}")]
        public string KubeConfig
        {
            get;
            set;
        }

        private object? _acceptUntrustedCerts;

        /// <summary>Enable this if your authentication uses untrusted certificates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#accept_untrusted_certs ServiceendpointKubernetes#accept_untrusted_certs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AcceptUntrustedCerts
        {
            get => _acceptUntrustedCerts;
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
                _acceptUntrustedCerts = value;
            }
        }

        /// <summary>Context of your cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_context ServiceendpointKubernetes#cluster_context}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterContext
        {
            get;
            set;
        }
    }
}
