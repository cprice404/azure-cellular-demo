using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionSchedulesBranchFilter")]
    public class BuildDefinitionSchedulesBranchFilter : azuredevops.BuildDefinition.IBuildDefinitionSchedulesBranchFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#exclude BuildDefinition#exclude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Exclude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#include BuildDefinition#include}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Include
        {
            get;
            set;
        }
    }
}
