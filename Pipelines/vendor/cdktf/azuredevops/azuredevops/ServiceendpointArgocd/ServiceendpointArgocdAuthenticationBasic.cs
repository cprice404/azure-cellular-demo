using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArgocd
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationBasic")]
    public class ServiceendpointArgocdAuthenticationBasic : azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationBasic
    {
        /// <summary>The ArgoCD password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#password ServiceendpointArgocd#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>The ArgoCD user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#username ServiceendpointArgocd#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
