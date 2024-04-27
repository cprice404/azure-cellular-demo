using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.VariableGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.variableGroup.VariableGroupKeyVault")]
    public class VariableGroupKeyVault : azuredevops.VariableGroup.IVariableGroupKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#name VariableGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#service_endpoint_id VariableGroup#service_endpoint_id}.</summary>
        [JsiiProperty(name: "serviceEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#search_depth VariableGroup#search_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SearchDepth
        {
            get;
            set;
        }
    }
}
