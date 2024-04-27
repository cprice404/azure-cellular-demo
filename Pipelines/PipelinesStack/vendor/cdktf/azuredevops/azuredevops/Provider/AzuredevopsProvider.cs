using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.Provider
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs azuredevops}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.Provider.AzuredevopsProvider), fullyQualifiedName: "azuredevops.provider.AzuredevopsProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"azuredevops.provider.AzuredevopsProviderConfig\"}}]")]
    public class AzuredevopsProvider : HashiCorp.Cdktf.TerraformProvider
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs azuredevops} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AzuredevopsProvider(Constructs.Construct scope, string id, azuredevops.Provider.IAzuredevopsProviderConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.Provider.IAzuredevopsProviderConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AzuredevopsProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AzuredevopsProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a AzuredevopsProvider resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AzuredevopsProvider to import.</param>
        /// <param name="importFromId">The id of the existing AzuredevopsProvider that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AzuredevopsProvider to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AzuredevopsProvider to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AzuredevopsProvider that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AzuredevopsProvider to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.Provider.AzuredevopsProvider), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificate")]
        public virtual void ResetClientCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificatePassword")]
        public virtual void ResetClientCertificatePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificatePath")]
        public virtual void ResetClientCertificatePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientId")]
        public virtual void ResetClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientIdApply")]
        public virtual void ResetClientIdApply()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientIdPlan")]
        public virtual void ResetClientIdPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientSecret")]
        public virtual void ResetClientSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientSecretPath")]
        public virtual void ResetClientSecretPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcAudience")]
        public virtual void ResetOidcAudience()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcRequestToken")]
        public virtual void ResetOidcRequestToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcRequestUrl")]
        public virtual void ResetOidcRequestUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcTfcTag")]
        public virtual void ResetOidcTfcTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcToken")]
        public virtual void ResetOidcToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcTokenFilePath")]
        public virtual void ResetOidcTokenFilePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrgServiceUrl")]
        public virtual void ResetOrgServiceUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersonalAccessToken")]
        public virtual void ResetPersonalAccessToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTenantId")]
        public virtual void ResetTenantId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTenantIdApply")]
        public virtual void ResetTenantIdApply()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTenantIdPlan")]
        public virtual void ResetTenantIdPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUseMsi")]
        public virtual void ResetUseMsi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUseOidc")]
        public virtual void ResetUseOidc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azuredevops.Provider.AzuredevopsProvider))!;

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificatePasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificatePasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificatePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificatePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdApplyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdApplyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdPlanInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdPlanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSecretPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientSecretPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcAudienceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcAudienceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcRequestTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcRequestTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcRequestUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcRequestUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcTfcTagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcTfcTagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcTokenFilePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcTokenFilePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orgServiceUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrgServiceUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "personalAccessTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersonalAccessTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenantIdApplyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenantIdApplyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenantIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenantIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenantIdPlanInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenantIdPlanInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "useMsiInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UseMsiInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "useOidcInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UseOidcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public override string? Alias
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificate
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificatePassword
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificatePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificatePath
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientId
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdApply", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdApply
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdPlan
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientSecret
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientSecretPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientSecretPath
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcAudience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcAudience
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcRequestToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcRequestToken
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcRequestUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcRequestUrl
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcTfcTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcTfcTag
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcToken
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcTokenFilePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OidcTokenFilePath
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "orgServiceUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrgServiceUrl
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersonalAccessToken
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenantId
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenantIdApply", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenantIdApply
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenantIdPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenantIdPlan
        {
            get => GetInstanceProperty<string?>();
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "useMsi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UseMsi
        {
            get => GetInstanceProperty<object?>();
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
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "useOidc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UseOidc
        {
            get => GetInstanceProperty<object?>();
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
                SetInstanceProperty(value);
            }
        }
    }
}
