using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurerm
{
    [JsiiInterface(nativeType: typeof(IServiceendpointAzurermFeatures), fullyQualifiedName: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermFeatures")]
    public interface IServiceendpointAzurermFeatures
    {
        /// <summary>Whether or not to validate connection with azure after create or update operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#validate ServiceendpointAzurerm#validate}
        /// </remarks>
        [JsiiProperty(name: "validate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Validate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointAzurermFeatures), fullyQualifiedName: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermFeatures")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether or not to validate connection with azure after create or update operations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#validate ServiceendpointAzurerm#validate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Validate
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
