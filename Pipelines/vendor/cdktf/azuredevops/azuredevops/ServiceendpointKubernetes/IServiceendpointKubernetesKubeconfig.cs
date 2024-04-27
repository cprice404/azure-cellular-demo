using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    [JsiiInterface(nativeType: typeof(IServiceendpointKubernetesKubeconfig), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesKubeconfig")]
    public interface IServiceendpointKubernetesKubeconfig
    {
        /// <summary>Content of the kubeconfig file.</summary>
        /// <remarks>
        /// The configuration information in your kubeconfig file allows Kubernetes clients to talk to your Kubernetes API servers. This file is used by kubectl and all supported Kubernetes clients.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#kube_config ServiceendpointKubernetes#kube_config}
        /// </remarks>
        [JsiiProperty(name: "kubeConfig", typeJson: "{\"primitive\":\"string\"}")]
        string KubeConfig
        {
            get;
        }

        /// <summary>Enable this if your authentication uses untrusted certificates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#accept_untrusted_certs ServiceendpointKubernetes#accept_untrusted_certs}
        /// </remarks>
        [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AcceptUntrustedCerts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Context of your cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_context ServiceendpointKubernetes#cluster_context}
        /// </remarks>
        [JsiiProperty(name: "clusterContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterContext
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointKubernetesKubeconfig), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesKubeconfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesKubeconfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Content of the kubeconfig file.</summary>
            /// <remarks>
            /// The configuration information in your kubeconfig file allows Kubernetes clients to talk to your Kubernetes API servers. This file is used by kubectl and all supported Kubernetes clients.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#kube_config ServiceendpointKubernetes#kube_config}
            /// </remarks>
            [JsiiProperty(name: "kubeConfig", typeJson: "{\"primitive\":\"string\"}")]
            public string KubeConfig
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Enable this if your authentication uses untrusted certificates.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#accept_untrusted_certs ServiceendpointKubernetes#accept_untrusted_certs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AcceptUntrustedCerts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Context of your cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#cluster_context ServiceendpointKubernetes#cluster_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterContext
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
