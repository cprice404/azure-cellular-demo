using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurerm
{
    [JsiiByValue(fqn: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermFeatures")]
    public class ServiceendpointAzurermFeatures : azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures
    {
        private object? _validate;

        /// <summary>Whether or not to validate connection with azure after create or update operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#validate ServiceendpointAzurerm#validate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Validate
        {
            get => _validate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _validate = value;
            }
        }
    }
}
