using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogArtifactoryV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationBasic")]
    public class ServiceendpointJfrogArtifactoryV2AuthenticationBasic : azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationBasic
    {
        /// <summary>The JFrog Artifactory password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_artifactory_v2#password ServiceendpointJfrogArtifactoryV2#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>The JFrog Artifactory user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_artifactory_v2#username ServiceendpointJfrogArtifactoryV2#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
