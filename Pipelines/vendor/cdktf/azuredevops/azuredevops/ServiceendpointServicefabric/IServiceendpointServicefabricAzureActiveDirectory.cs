using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointServicefabric
{
    [JsiiInterface(nativeType: typeof(IServiceendpointServicefabricAzureActiveDirectory), fullyQualifiedName: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectory")]
    public interface IServiceendpointServicefabricAzureActiveDirectory
    {
        /// <summary>Password for the Azure Active Directory account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#password ServiceendpointServicefabric#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#server_certificate_lookup ServiceendpointServicefabric#server_certificate_lookup}.</summary>
        [JsiiProperty(name: "serverCertificateLookup", typeJson: "{\"primitive\":\"string\"}")]
        string ServerCertificateLookup
        {
            get;
        }

        /// <summary>Specify an Azure Active Directory account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#username ServiceendpointServicefabric#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        /// <summary>The common name(s) of the cluster's certificate(s).</summary>
        /// <remarks>
        /// This is used to verify the identity of the cluster. This value overrides the publish profile. Separate multiple common names with a comma (',')
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#server_certificate_common_name ServiceendpointServicefabric#server_certificate_common_name}
        /// </remarks>
        [JsiiProperty(name: "serverCertificateCommonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerCertificateCommonName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The thumbprint(s) of the cluster's certificate(s).</summary>
        /// <remarks>
        /// This is used to verify the identity of the cluster. This value overrides the publish profile. Separate multiple thumbprints with a comma (',')
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#server_certificate_thumbprint ServiceendpointServicefabric#server_certificate_thumbprint}
        /// </remarks>
        [JsiiProperty(name: "serverCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerCertificateThumbprint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointServicefabricAzureActiveDirectory), fullyQualifiedName: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricAzureActiveDirectory")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricAzureActiveDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Password for the Azure Active Directory account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#password ServiceendpointServicefabric#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#server_certificate_lookup ServiceendpointServicefabric#server_certificate_lookup}.</summary>
            [JsiiProperty(name: "serverCertificateLookup", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerCertificateLookup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specify an Azure Active Directory account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#username ServiceendpointServicefabric#username}
            /// </remarks>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
