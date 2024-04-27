using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointMaven
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointMaven.ServiceendpointMavenAuthenticationBasic")]
    public class ServiceendpointMavenAuthenticationBasic : azuredevops.ServiceendpointMaven.IServiceendpointMavenAuthenticationBasic
    {
        /// <summary>The Maven password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#password ServiceendpointMaven#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>The Maven user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#username ServiceendpointMaven#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
