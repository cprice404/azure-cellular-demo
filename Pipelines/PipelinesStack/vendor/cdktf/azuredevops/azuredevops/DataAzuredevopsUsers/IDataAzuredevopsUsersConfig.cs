using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsUsers
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsUsersConfig), fullyQualifiedName: "azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersConfig")]
    public interface IDataAzuredevopsUsersConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#features DataAzuredevopsUsers#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersFeatures\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersFeatures? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#id DataAzuredevopsUsers#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#origin DataAzuredevopsUsers#origin}.</summary>
        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Origin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#origin_id DataAzuredevopsUsers#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#principal_name DataAzuredevopsUsers#principal_name}.</summary>
        [JsiiProperty(name: "principalName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrincipalName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#subject_types DataAzuredevopsUsers#subject_types}.</summary>
        [JsiiProperty(name: "subjectTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubjectTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsUsersConfig), fullyQualifiedName: "azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#features DataAzuredevopsUsers#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersFeatures\"}", isOptional: true)]
            public azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersFeatures? Features
            {
                get => GetInstanceProperty<azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersFeatures?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#id DataAzuredevopsUsers#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#origin DataAzuredevopsUsers#origin}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Origin
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#origin_id DataAzuredevopsUsers#origin_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#principal_name DataAzuredevopsUsers#principal_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "principalName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrincipalName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/data-sources/users#subject_types DataAzuredevopsUsers#subject_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubjectTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
