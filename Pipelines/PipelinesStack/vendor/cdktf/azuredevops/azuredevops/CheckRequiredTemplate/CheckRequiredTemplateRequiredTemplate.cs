using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.CheckRequiredTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.checkRequiredTemplate.CheckRequiredTemplateRequiredTemplate")]
    public class CheckRequiredTemplateRequiredTemplate : azuredevops.CheckRequiredTemplate.ICheckRequiredTemplateRequiredTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_name CheckRequiredTemplate#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_ref CheckRequiredTemplate#repository_ref}.</summary>
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryRef
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#template_path CheckRequiredTemplate#template_path}.</summary>
        [JsiiProperty(name: "templatePath", typeJson: "{\"primitive\":\"string\"}")]
        public string TemplatePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_type CheckRequiredTemplate#repository_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepositoryType
        {
            get;
            set;
        }
    }
}
