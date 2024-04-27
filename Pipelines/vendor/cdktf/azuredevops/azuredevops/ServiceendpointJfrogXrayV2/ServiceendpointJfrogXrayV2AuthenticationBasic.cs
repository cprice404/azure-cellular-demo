using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogXrayV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointJfrogXrayV2.ServiceendpointJfrogXrayV2AuthenticationBasic")]
    public class ServiceendpointJfrogXrayV2AuthenticationBasic : azuredevops.ServiceendpointJfrogXrayV2.IServiceendpointJfrogXrayV2AuthenticationBasic
    {
        /// <summary>The JFrog Artifactory password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_xray_v2#password ServiceendpointJfrogXrayV2#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>The JFrog Artifactory user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_xray_v2#username ServiceendpointJfrogXrayV2#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
