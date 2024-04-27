using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArtifactory
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationToken")]
    public class ServiceendpointArtifactoryAuthenticationToken : azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationToken
    {
        /// <summary>The Artifactory access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#token ServiceendpointArtifactory#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }
    }
}
