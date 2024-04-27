using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    [JsiiInterface(nativeType: typeof(IServiceendpointKubernetesServiceAccount), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccount")]
    public interface IServiceendpointKubernetesServiceAccount
    {
        /// <summary>Secret cert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#ca_cert ServiceendpointKubernetes#ca_cert}
        /// </remarks>
        [JsiiProperty(name: "caCert", typeJson: "{\"primitive\":\"string\"}")]
        string CaCert
        {
            get;
        }

        /// <summary>Secret token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#token ServiceendpointKubernetes#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointKubernetesServiceAccount), fullyQualifiedName: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccount")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Secret cert.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#ca_cert ServiceendpointKubernetes#ca_cert}
            /// </remarks>
            [JsiiProperty(name: "caCert", typeJson: "{\"primitive\":\"string\"}")]
            public string CaCert
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Secret token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#token ServiceendpointKubernetes#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
