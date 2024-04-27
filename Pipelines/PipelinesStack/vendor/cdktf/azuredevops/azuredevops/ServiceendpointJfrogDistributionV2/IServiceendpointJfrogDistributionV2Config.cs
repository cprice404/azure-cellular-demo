using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogDistributionV2
{
    [JsiiInterface(nativeType: typeof(IServiceendpointJfrogDistributionV2Config), fullyQualifiedName: "azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2Config")]
    public interface IServiceendpointJfrogDistributionV2Config : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#project_id ServiceendpointJfrogDistributionV2#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#service_endpoint_name ServiceendpointJfrogDistributionV2#service_endpoint_name}.</summary>
        [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceEndpointName
        {
            get;
        }

        /// <summary>Url for the JFrog Artifactory Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#url ServiceendpointJfrogDistributionV2#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>authentication_basic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#authentication_basic ServiceendpointJfrogDistributionV2#authentication_basic}
        /// </remarks>
        [JsiiProperty(name: "authenticationBasic", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2AuthenticationBasic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2AuthenticationBasic? AuthenticationBasic
        {
            get
            {
                return null;
            }
        }

        /// <summary>authentication_token block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#authentication_token ServiceendpointJfrogDistributionV2#authentication_token}
        /// </remarks>
        [JsiiProperty(name: "authenticationToken", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2AuthenticationToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2AuthenticationToken? AuthenticationToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#authorization ServiceendpointJfrogDistributionV2#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#description ServiceendpointJfrogDistributionV2#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#id ServiceendpointJfrogDistributionV2#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#timeouts ServiceendpointJfrogDistributionV2#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2Timeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2Timeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointJfrogDistributionV2Config), fullyQualifiedName: "azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2Config")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2Config
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#project_id ServiceendpointJfrogDistributionV2#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#service_endpoint_name ServiceendpointJfrogDistributionV2#service_endpoint_name}.</summary>
            [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceEndpointName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Url for the JFrog Artifactory Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#url ServiceendpointJfrogDistributionV2#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authentication_basic block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#authentication_basic ServiceendpointJfrogDistributionV2#authentication_basic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationBasic", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2AuthenticationBasic\"}", isOptional: true)]
            public azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2AuthenticationBasic? AuthenticationBasic
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2AuthenticationBasic?>();
            }

            /// <summary>authentication_token block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#authentication_token ServiceendpointJfrogDistributionV2#authentication_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationToken", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2AuthenticationToken\"}", isOptional: true)]
            public azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2AuthenticationToken? AuthenticationToken
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2AuthenticationToken?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#authorization ServiceendpointJfrogDistributionV2#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Authorization
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#description ServiceendpointJfrogDistributionV2#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#id ServiceendpointJfrogDistributionV2#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#timeouts ServiceendpointJfrogDistributionV2#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2Timeouts\"}", isOptional: true)]
            public azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2Timeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2Timeouts?>();
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
