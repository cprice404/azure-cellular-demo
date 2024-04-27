using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointMaven
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointMaven.ServiceendpointMavenAuthenticationToken")]
    public class ServiceendpointMavenAuthenticationToken : azuredevops.ServiceendpointMaven.IServiceendpointMavenAuthenticationToken
    {
        /// <summary>The Maven access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#token ServiceendpointMaven#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }
    }
}
