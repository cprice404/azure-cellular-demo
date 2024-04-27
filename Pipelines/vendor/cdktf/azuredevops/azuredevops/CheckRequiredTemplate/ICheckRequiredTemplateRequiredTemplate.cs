using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.CheckRequiredTemplate
{
    [JsiiInterface(nativeType: typeof(ICheckRequiredTemplateRequiredTemplate), fullyQualifiedName: "azuredevops.checkRequiredTemplate.CheckRequiredTemplateRequiredTemplate")]
    public interface ICheckRequiredTemplateRequiredTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_name CheckRequiredTemplate#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_ref CheckRequiredTemplate#repository_ref}.</summary>
        [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryRef
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#template_path CheckRequiredTemplate#template_path}.</summary>
        [JsiiProperty(name: "templatePath", typeJson: "{\"primitive\":\"string\"}")]
        string TemplatePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_type CheckRequiredTemplate#repository_type}.</summary>
        [JsiiProperty(name: "repositoryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICheckRequiredTemplateRequiredTemplate), fullyQualifiedName: "azuredevops.checkRequiredTemplate.CheckRequiredTemplateRequiredTemplate")]
        internal sealed class _Proxy : DeputyBase, azuredevops.CheckRequiredTemplate.ICheckRequiredTemplateRequiredTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_name CheckRequiredTemplate#repository_name}.</summary>
            [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_ref CheckRequiredTemplate#repository_ref}.</summary>
            [JsiiProperty(name: "repositoryRef", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryRef
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#template_path CheckRequiredTemplate#template_path}.</summary>
            [JsiiProperty(name: "templatePath", typeJson: "{\"primitive\":\"string\"}")]
            public string TemplatePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/check_required_template#repository_type CheckRequiredTemplate#repository_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
