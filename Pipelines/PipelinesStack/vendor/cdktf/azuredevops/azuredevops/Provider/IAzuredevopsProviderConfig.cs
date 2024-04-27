using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.Provider
{
    [JsiiInterface(nativeType: typeof(IAzuredevopsProviderConfig), fullyQualifiedName: "azuredevops.provider.AzuredevopsProviderConfig")]
    public interface IAzuredevopsProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#alias AzuredevopsProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Base64 encoded certificate to use to authenticate to the service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate AzuredevopsProvider#client_certificate}
        /// </remarks>
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password for a client certificate password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate_password AzuredevopsProvider#client_certificate_password}
        /// </remarks>
        [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificatePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Path to a certificate to use to authenticate to the service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate_path AzuredevopsProvider#client_certificate_path}
        /// </remarks>
        [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificatePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The service principal client or managed service principal id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id AzuredevopsProvider#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The service principal client id which should be used during an apply operation in Terraform Cloud.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id_apply AzuredevopsProvider#client_id_apply}
        /// </remarks>
        [JsiiProperty(name: "clientIdApply", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientIdApply
        {
            get
            {
                return null;
            }
        }

        /// <summary>The service principal client id which should be used during a plan operation in Terraform Cloud.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id_plan AzuredevopsProvider#client_id_plan}
        /// </remarks>
        [JsiiProperty(name: "clientIdPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientIdPlan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Client secret for authenticating to  a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_secret AzuredevopsProvider#client_secret}
        /// </remarks>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>Path to a file containing a client secret for authenticating to  a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_secret_path AzuredevopsProvider#client_secret_path}
        /// </remarks>
        [JsiiProperty(name: "clientSecretPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientSecretPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set the audience when requesting OIDC tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_audience AzuredevopsProvider#oidc_audience}
        /// </remarks>
        [JsiiProperty(name: "oidcAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcAudience
        {
            get
            {
                return null;
            }
        }

        /// <summary>The bearer token for the request to the OIDC provider.</summary>
        /// <remarks>
        /// For use when authenticating as a Service Principal using OpenID Connect.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_request_token AzuredevopsProvider#oidc_request_token}
        /// </remarks>
        [JsiiProperty(name: "oidcRequestToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcRequestToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>The URL for the OIDC provider from which to request an ID token.</summary>
        /// <remarks>
        /// For use when authenticating as a Service Principal using OpenID Connect.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_request_url AzuredevopsProvider#oidc_request_url}
        /// </remarks>
        [JsiiProperty(name: "oidcRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcRequestUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Terraform Cloud dynamic credential provider tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_tfc_tag AzuredevopsProvider#oidc_tfc_tag}
        /// </remarks>
        [JsiiProperty(name: "oidcTfcTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcTfcTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>OIDC token to authenticate as a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_token AzuredevopsProvider#oidc_token}
        /// </remarks>
        [JsiiProperty(name: "oidcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>OIDC token from file to authenticate as a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_token_file_path AzuredevopsProvider#oidc_token_file_path}
        /// </remarks>
        [JsiiProperty(name: "oidcTokenFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OidcTokenFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The url of the Azure DevOps instance which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#org_service_url AzuredevopsProvider#org_service_url}
        /// </remarks>
        [JsiiProperty(name: "orgServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrgServiceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The personal access token which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#personal_access_token AzuredevopsProvider#personal_access_token}
        /// </remarks>
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersonalAccessToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>The service principal tenant id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id AzuredevopsProvider#tenant_id}
        /// </remarks>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The service principal tenant id which should be used during an apply operation in Terraform Cloud..</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id_apply AzuredevopsProvider#tenant_id_apply}
        /// </remarks>
        [JsiiProperty(name: "tenantIdApply", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantIdApply
        {
            get
            {
                return null;
            }
        }

        /// <summary>The service principal tenant id which should be used during a plan operation in Terraform Cloud.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id_plan AzuredevopsProvider#tenant_id_plan}
        /// </remarks>
        [JsiiProperty(name: "tenantIdPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantIdPlan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Use an Azure Managed Service Identity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#use_msi AzuredevopsProvider#use_msi}
        /// </remarks>
        [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseMsi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Use an OIDC token to authenticate to a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#use_oidc AzuredevopsProvider#use_oidc}
        /// </remarks>
        [JsiiProperty(name: "useOidc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseOidc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzuredevopsProviderConfig), fullyQualifiedName: "azuredevops.provider.AzuredevopsProviderConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.Provider.IAzuredevopsProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#alias AzuredevopsProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Base64 encoded certificate to use to authenticate to the service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate AzuredevopsProvider#client_certificate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password for a client certificate password.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate_password AzuredevopsProvider#client_certificate_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificatePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Path to a certificate to use to authenticate to the service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate_path AzuredevopsProvider#client_certificate_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificatePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The service principal client or managed service principal id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id AzuredevopsProvider#client_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The service principal client id which should be used during an apply operation in Terraform Cloud.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id_apply AzuredevopsProvider#client_id_apply}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientIdApply", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientIdApply
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The service principal client id which should be used during a plan operation in Terraform Cloud.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id_plan AzuredevopsProvider#client_id_plan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientIdPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientIdPlan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Client secret for authenticating to  a service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_secret AzuredevopsProvider#client_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Path to a file containing a client secret for authenticating to  a service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_secret_path AzuredevopsProvider#client_secret_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSecretPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientSecretPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set the audience when requesting OIDC tokens.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_audience AzuredevopsProvider#oidc_audience}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcAudience
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The bearer token for the request to the OIDC provider.</summary>
            /// <remarks>
            /// For use when authenticating as a Service Principal using OpenID Connect.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_request_token AzuredevopsProvider#oidc_request_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcRequestToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcRequestToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The URL for the OIDC provider from which to request an ID token.</summary>
            /// <remarks>
            /// For use when authenticating as a Service Principal using OpenID Connect.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_request_url AzuredevopsProvider#oidc_request_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcRequestUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Terraform Cloud dynamic credential provider tag.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_tfc_tag AzuredevopsProvider#oidc_tfc_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcTfcTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcTfcTag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>OIDC token to authenticate as a service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_token AzuredevopsProvider#oidc_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>OIDC token from file to authenticate as a service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_token_file_path AzuredevopsProvider#oidc_token_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcTokenFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OidcTokenFilePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The url of the Azure DevOps instance which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#org_service_url AzuredevopsProvider#org_service_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orgServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrgServiceUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The personal access token which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#personal_access_token AzuredevopsProvider#personal_access_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersonalAccessToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The service principal tenant id which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id AzuredevopsProvider#tenant_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The service principal tenant id which should be used during an apply operation in Terraform Cloud..</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id_apply AzuredevopsProvider#tenant_id_apply}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantIdApply", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantIdApply
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The service principal tenant id which should be used during a plan operation in Terraform Cloud.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id_plan AzuredevopsProvider#tenant_id_plan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantIdPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantIdPlan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Use an Azure Managed Service Identity.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#use_msi AzuredevopsProvider#use_msi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseMsi
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Use an OIDC token to authenticate to a service principal.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#use_oidc AzuredevopsProvider#use_oidc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "useOidc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseOidc
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
