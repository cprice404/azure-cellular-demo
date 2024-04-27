using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.Provider
{
    [JsiiByValue(fqn: "azuredevops.provider.AzuredevopsProviderConfig")]
    public class AzuredevopsProviderConfig : azuredevops.Provider.IAzuredevopsProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#alias AzuredevopsProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>Base64 encoded certificate to use to authenticate to the service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate AzuredevopsProvider#client_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificate
        {
            get;
            set;
        }

        /// <summary>Password for a client certificate password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate_password AzuredevopsProvider#client_certificate_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificatePassword
        {
            get;
            set;
        }

        /// <summary>Path to a certificate to use to authenticate to the service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_certificate_path AzuredevopsProvider#client_certificate_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificatePath
        {
            get;
            set;
        }

        /// <summary>The service principal client or managed service principal id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id AzuredevopsProvider#client_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>The service principal client id which should be used during an apply operation in Terraform Cloud.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id_apply AzuredevopsProvider#client_id_apply}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientIdApply", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientIdApply
        {
            get;
            set;
        }

        /// <summary>The service principal client id which should be used during a plan operation in Terraform Cloud.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_id_plan AzuredevopsProvider#client_id_plan}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientIdPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientIdPlan
        {
            get;
            set;
        }

        /// <summary>Client secret for authenticating to  a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_secret AzuredevopsProvider#client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        /// <summary>Path to a file containing a client secret for authenticating to  a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#client_secret_path AzuredevopsProvider#client_secret_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecretPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecretPath
        {
            get;
            set;
        }

        /// <summary>Set the audience when requesting OIDC tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_audience AzuredevopsProvider#oidc_audience}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oidcAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OidcAudience
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Terraform Cloud dynamic credential provider tag.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_tfc_tag AzuredevopsProvider#oidc_tfc_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oidcTfcTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OidcTfcTag
        {
            get;
            set;
        }

        /// <summary>OIDC token to authenticate as a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_token AzuredevopsProvider#oidc_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oidcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OidcToken
        {
            get;
            set;
        }

        /// <summary>OIDC token from file to authenticate as a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#oidc_token_file_path AzuredevopsProvider#oidc_token_file_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oidcTokenFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OidcTokenFilePath
        {
            get;
            set;
        }

        /// <summary>The url of the Azure DevOps instance which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#org_service_url AzuredevopsProvider#org_service_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orgServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrgServiceUrl
        {
            get;
            set;
        }

        /// <summary>The personal access token which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#personal_access_token AzuredevopsProvider#personal_access_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersonalAccessToken
        {
            get;
            set;
        }

        /// <summary>The service principal tenant id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id AzuredevopsProvider#tenant_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenantId
        {
            get;
            set;
        }

        /// <summary>The service principal tenant id which should be used during an apply operation in Terraform Cloud..</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id_apply AzuredevopsProvider#tenant_id_apply}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tenantIdApply", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenantIdApply
        {
            get;
            set;
        }

        /// <summary>The service principal tenant id which should be used during a plan operation in Terraform Cloud.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#tenant_id_plan AzuredevopsProvider#tenant_id_plan}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tenantIdPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenantIdPlan
        {
            get;
            set;
        }

        private object? _useMsi;

        /// <summary>Use an Azure Managed Service Identity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#use_msi AzuredevopsProvider#use_msi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseMsi
        {
            get => _useMsi;
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
                _useMsi = value;
            }
        }

        private object? _useOidc;

        /// <summary>Use an OIDC token to authenticate to a service principal.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#use_oidc AzuredevopsProvider#use_oidc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useOidc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseOidc
        {
            get => _useOidc;
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
                _useOidc = value;
            }
        }
    }
}
