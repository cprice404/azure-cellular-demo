using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointServicefabric
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectory")]
    public class ServiceendpointServicefabricAzureActiveDirectory : azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory
    {
        /// <summary>Password for the Azure Active Directory account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#password ServiceendpointServicefabric#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#server_certificate_lookup ServiceendpointServicefabric#server_certificate_lookup}.</summary>
        [JsiiProperty(name: "serverCertificateLookup", typeJson: "{\"primitive\":\"string\"}")]
        public string ServerCertificateLookup
        {
            get;
            set;
        }

        /// <summary>Specify an Azure Active Directory account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#username ServiceendpointServicefabric#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>The common name(s) of the cluster's certificate(s).</summary>
        /// <remarks>
        /// This is used to verify the identity of the cluster. This value overrides the publish profile. Separate multiple common names with a comma (',')
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#server_certificate_common_name ServiceendpointServicefabric#server_certificate_common_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverCertificateCommonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerCertificateCommonName
        {
            get;
            set;
        }

        /// <summary>The thumbprint(s) of the cluster's certificate(s).</summary>
        /// <remarks>
        /// This is used to verify the identity of the cluster. This value overrides the publish profile. Separate multiple thumbprints with a comma (',')
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#server_certificate_thumbprint ServiceendpointServicefabric#server_certificate_thumbprint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerCertificateThumbprint
        {
            get;
            set;
        }
    }
}
