using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccount")]
    public class ServiceendpointKubernetesServiceAccount : azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount
    {
        /// <summary>Secret cert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#ca_cert ServiceendpointKubernetes#ca_cert}
        /// </remarks>
        [JsiiProperty(name: "caCert", typeJson: "{\"primitive\":\"string\"}")]
        public string CaCert
        {
            get;
            set;
        }

        /// <summary>Secret token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_kubernetes#token ServiceendpointKubernetes#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }
    }
}
