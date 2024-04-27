using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointServicefabric
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricCertificate")]
    public class ServiceendpointServicefabricCertificate : azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricCertificate
    {
        /// <summary>Base64 encoding of the cluster's client certificate file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#client_certificate ServiceendpointServicefabric#client_certificate}
        /// </remarks>
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientCertificate
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

        /// <summary>Password for the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#client_certificate_password ServiceendpointServicefabric#client_certificate_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificatePassword
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
