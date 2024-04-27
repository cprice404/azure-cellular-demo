using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArgocd
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationToken")]
    public class ServiceendpointArgocdAuthenticationToken : azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationToken
    {
        /// <summary>The ArgoCD access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#token ServiceendpointArgocd#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }
    }
}
