using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointGithub.ServiceendpointGithubAuthOauth")]
    public class ServiceendpointGithubAuthOauth : azuredevops.ServiceendpointGithub.IServiceendpointGithubAuthOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_github#oauth_configuration_id ServiceendpointGithub#oauth_configuration_id}.</summary>
        [JsiiProperty(name: "oauthConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        public string OauthConfigurationId
        {
            get;
            set;
        }
    }
}
