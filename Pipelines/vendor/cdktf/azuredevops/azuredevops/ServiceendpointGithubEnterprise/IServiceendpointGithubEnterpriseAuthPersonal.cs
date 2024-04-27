using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithubEnterprise
{
    [JsiiInterface(nativeType: typeof(IServiceendpointGithubEnterpriseAuthPersonal), fullyQualifiedName: "azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonal")]
    public interface IServiceendpointGithubEnterpriseAuthPersonal
    {
        /// <summary>The GitHub personal access token which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_github_enterprise#personal_access_token ServiceendpointGithubEnterprise#personal_access_token}
        /// </remarks>
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        string PersonalAccessToken
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointGithubEnterpriseAuthPersonal), fullyQualifiedName: "azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonal")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthPersonal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The GitHub personal access token which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_github_enterprise#personal_access_token ServiceendpointGithubEnterprise#personal_access_token}
            /// </remarks>
            [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
            public string PersonalAccessToken
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
