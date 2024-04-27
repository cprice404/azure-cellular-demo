using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionCiTrigger), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionCiTrigger")]
    public interface IBuildDefinitionCiTrigger
    {
        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#override BuildDefinition#override}
        /// </remarks>
        [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverride\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride? Override
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#use_yaml BuildDefinition#use_yaml}.</summary>
        [JsiiProperty(name: "useYaml", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseYaml
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionCiTrigger), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionCiTrigger")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionCiTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#override BuildDefinition#override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverride\"}", isOptional: true)]
            public azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride? Override
            {
                get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#use_yaml BuildDefinition#use_yaml}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useYaml", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseYaml
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
