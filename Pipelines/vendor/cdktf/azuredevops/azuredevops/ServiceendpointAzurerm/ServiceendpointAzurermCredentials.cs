using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurerm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentials")]
    public class ServiceendpointAzurermCredentials : azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials
    {
        /// <summary>The service principal id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#serviceprincipalid ServiceendpointAzurerm#serviceprincipalid}
        /// </remarks>
        [JsiiProperty(name: "serviceprincipalid", typeJson: "{\"primitive\":\"string\"}")]
        public string Serviceprincipalid
        {
            get;
            set;
        }

        /// <summary>The service principal secret which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#serviceprincipalkey ServiceendpointAzurerm#serviceprincipalkey}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceprincipalkey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Serviceprincipalkey
        {
            get;
            set;
        }
    }
}
