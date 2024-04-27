using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArtifactory
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationBasic")]
    public class ServiceendpointArtifactoryAuthenticationBasic : azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationBasic
    {
        /// <summary>The Artifactory password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#password ServiceendpointArtifactory#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>The Artifactory user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#username ServiceendpointArtifactory#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
