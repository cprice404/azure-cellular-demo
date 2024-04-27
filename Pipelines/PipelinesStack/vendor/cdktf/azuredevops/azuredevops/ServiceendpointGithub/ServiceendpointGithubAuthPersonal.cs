using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointGithub.ServiceendpointGithubAuthPersonal")]
    public class ServiceendpointGithubAuthPersonal : azuredevops.ServiceendpointGithub.IServiceendpointGithubAuthPersonal
    {
        /// <summary>The GitHub personal access token which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_github#personal_access_token ServiceendpointGithub#personal_access_token}
        /// </remarks>
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        public string PersonalAccessToken
        {
            get;
            set;
        }
    }
}
