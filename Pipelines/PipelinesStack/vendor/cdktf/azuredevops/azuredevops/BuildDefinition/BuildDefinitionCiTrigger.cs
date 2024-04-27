using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    [JsiiByValue(fqn: "azuredevops.buildDefinition.BuildDefinitionCiTrigger")]
    public class BuildDefinitionCiTrigger : azuredevops.BuildDefinition.IBuildDefinitionCiTrigger
    {
        /// <summary>override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#override BuildDefinition#override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "override", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOverride\"}", isOptional: true)]
        public azuredevops.BuildDefinition.IBuildDefinitionCiTriggerOverride? Override
        {
            get;
            set;
        }

        private object? _useYaml;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#use_yaml BuildDefinition#use_yaml}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useYaml", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseYaml
        {
            get => _useYaml;
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
                _useYaml = value;
            }
        }
    }
}
