using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.VariableGroup
{
    [JsiiInterface(nativeType: typeof(IVariableGroupKeyVault), fullyQualifiedName: "azuredevops.variableGroup.VariableGroupKeyVault")]
    public interface IVariableGroupKeyVault
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#name VariableGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#service_endpoint_id VariableGroup#service_endpoint_id}.</summary>
        [JsiiProperty(name: "serviceEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceEndpointId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#search_depth VariableGroup#search_depth}.</summary>
        [JsiiProperty(name: "searchDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SearchDepth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVariableGroupKeyVault), fullyQualifiedName: "azuredevops.variableGroup.VariableGroupKeyVault")]
        internal sealed class _Proxy : DeputyBase, azuredevops.VariableGroup.IVariableGroupKeyVault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#name VariableGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#service_endpoint_id VariableGroup#service_endpoint_id}.</summary>
            [JsiiProperty(name: "serviceEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/variable_group#search_depth VariableGroup#search_depth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SearchDepth
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
