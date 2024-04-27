using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiInterface(nativeType: typeof(IBuildDefinitionFeatures), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionFeatures")]
    public interface IBuildDefinitionFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#skip_first_run BuildDefinition#skip_first_run}.</summary>
        [JsiiProperty(name: "skipFirstRun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipFirstRun
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBuildDefinitionFeatures), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinitionFeatures")]
        internal sealed class _Proxy : DeputyBase, azuredevops.BuildDefinition.IBuildDefinitionFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#skip_first_run BuildDefinition#skip_first_run}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipFirstRun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipFirstRun
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
