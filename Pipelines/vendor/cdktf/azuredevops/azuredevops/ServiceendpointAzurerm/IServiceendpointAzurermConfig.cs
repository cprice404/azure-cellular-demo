using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurerm
{
    [JsiiInterface(nativeType: typeof(IServiceendpointAzurermConfig), fullyQualifiedName: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermConfig")]
    public interface IServiceendpointAzurermConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>The service principal tenant id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_spn_tenantid ServiceendpointAzurerm#azurerm_spn_tenantid}
        /// </remarks>
        [JsiiProperty(name: "azurermSpnTenantid", typeJson: "{\"primitive\":\"string\"}")]
        string AzurermSpnTenantid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#project_id ServiceendpointAzurerm#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#service_endpoint_name ServiceendpointAzurerm#service_endpoint_name}.</summary>
        [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceEndpointName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#authorization ServiceendpointAzurerm#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Authorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Azure managementGroup Id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_management_group_id ServiceendpointAzurerm#azurerm_management_group_id}
        /// </remarks>
        [JsiiProperty(name: "azurermManagementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzurermManagementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Azure managementGroup name which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_management_group_name ServiceendpointAzurerm#azurerm_management_group_name}
        /// </remarks>
        [JsiiProperty(name: "azurermManagementGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzurermManagementGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Azure subscription Id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_subscription_id ServiceendpointAzurerm#azurerm_subscription_id}
        /// </remarks>
        [JsiiProperty(name: "azurermSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzurermSubscriptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Azure subscription name which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_subscription_name ServiceendpointAzurerm#azurerm_subscription_name}
        /// </remarks>
        [JsiiProperty(name: "azurermSubscriptionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzurermSubscriptionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#credentials ServiceendpointAzurerm#credentials}
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#description ServiceendpointAzurerm#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Environment (Azure Cloud type).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#environment ServiceendpointAzurerm#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#features ServiceendpointAzurerm#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermFeatures\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#id ServiceendpointAzurerm#id}.</summary>
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

        /// <summary>Scope Resource Group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#resource_group ServiceendpointAzurerm#resource_group}
        /// </remarks>
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>The AzureRM Service Endpoint Authentication Scheme, this can be 'WorkloadIdentityFederation', 'ManagedServiceIdentity' or 'ServicePrincipal'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#service_endpoint_authentication_scheme ServiceendpointAzurerm#service_endpoint_authentication_scheme}
        /// </remarks>
        [JsiiProperty(name: "serviceEndpointAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceEndpointAuthenticationScheme
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#timeouts ServiceendpointAzurerm#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointAzurermConfig), fullyQualifiedName: "azuredevops.serviceendpointAzurerm.ServiceendpointAzurermConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The service principal tenant id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_spn_tenantid ServiceendpointAzurerm#azurerm_spn_tenantid}
            /// </remarks>
            [JsiiProperty(name: "azurermSpnTenantid", typeJson: "{\"primitive\":\"string\"}")]
            public string AzurermSpnTenantid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#project_id ServiceendpointAzurerm#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#service_endpoint_name ServiceendpointAzurerm#service_endpoint_name}.</summary>
            [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceEndpointName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#authorization ServiceendpointAzurerm#authorization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorization", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Authorization
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>The Azure managementGroup Id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_management_group_id ServiceendpointAzurerm#azurerm_management_group_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azurermManagementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzurermManagementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Azure managementGroup name which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_management_group_name ServiceendpointAzurerm#azurerm_management_group_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azurermManagementGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzurermManagementGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Azure subscription Id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_subscription_id ServiceendpointAzurerm#azurerm_subscription_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azurermSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzurermSubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Azure subscription name which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#azurerm_subscription_name ServiceendpointAzurerm#azurerm_subscription_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azurermSubscriptionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzurermSubscriptionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#credentials ServiceendpointAzurerm#credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermCredentials\"}", isOptional: true)]
            public azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials? Credentials
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermCredentials?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#description ServiceendpointAzurerm#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Environment (Azure Cloud type).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#environment ServiceendpointAzurerm#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Environment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#features ServiceendpointAzurerm#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermFeatures\"}", isOptional: true)]
            public azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures? Features
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermFeatures?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#id ServiceendpointAzurerm#id}.</summary>
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

            /// <summary>Scope Resource Group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#resource_group ServiceendpointAzurerm#resource_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The AzureRM Service Endpoint Authentication Scheme, this can be 'WorkloadIdentityFederation', 'ManagedServiceIdentity' or 'ServicePrincipal'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#service_endpoint_authentication_scheme ServiceendpointAzurerm#service_endpoint_authentication_scheme}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceEndpointAuthenticationScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceEndpointAuthenticationScheme
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_azurerm#timeouts ServiceendpointAzurerm#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointAzurerm.ServiceendpointAzurermTimeouts\"}", isOptional: true)]
            public azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.ServiceendpointAzurerm.IServiceendpointAzurermTimeouts?>();
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
