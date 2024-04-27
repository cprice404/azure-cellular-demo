using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurerm
{
    [JsiiInterface(nativeType: typeof(IServiceendpointAzurermCredentials), fullyQualifiedName: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentials")]
    public interface IServiceendpointAzurermCredentials
    {
        /// <summary>The service principal id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#serviceprincipalid ServiceendpointAzurerm#serviceprincipalid}
        /// </remarks>
        [JsiiProperty(name: "serviceprincipalid", typeJson: "{\"primitive\":\"string\"}")]
        string Serviceprincipalid
        {
            get;
        }

        /// <summary>The service principal secret which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#serviceprincipalkey ServiceendpointAzurerm#serviceprincipalkey}
        /// </remarks>
        [JsiiProperty(name: "serviceprincipalkey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Serviceprincipalkey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointAzurermCredentials), fullyQualifiedName: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentials")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The service principal id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#serviceprincipalid ServiceendpointAzurerm#serviceprincipalid}
            /// </remarks>
            [JsiiProperty(name: "serviceprincipalid", typeJson: "{\"primitive\":\"string\"}")]
            public string Serviceprincipalid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The service principal secret which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#serviceprincipalkey ServiceendpointAzurerm#serviceprincipalkey}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceprincipalkey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Serviceprincipalkey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
