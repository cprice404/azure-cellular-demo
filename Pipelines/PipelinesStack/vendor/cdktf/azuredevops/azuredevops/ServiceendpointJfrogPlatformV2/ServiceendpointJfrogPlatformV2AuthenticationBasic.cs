using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogPlatformV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointJfrogPlatformV2.ServiceendpointJfrogPlatformV2AuthenticationBasic")]
    public class ServiceendpointJfrogPlatformV2AuthenticationBasic : azuredevops.ServiceendpointJfrogPlatformV2.IServiceendpointJfrogPlatformV2AuthenticationBasic
    {
        /// <summary>The JFrog Artifactory password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_platform_v2#password ServiceendpointJfrogPlatformV2#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>The JFrog Artifactory user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_platform_v2#username ServiceendpointJfrogPlatformV2#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
