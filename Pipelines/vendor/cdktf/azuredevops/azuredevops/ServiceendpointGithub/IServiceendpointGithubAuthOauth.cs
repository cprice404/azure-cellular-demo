using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithub
{
    [JsiiInterface(nativeType: typeof(IServiceendpointGithubAuthOauth), fullyQualifiedName: "azuredevops.serviceendpointGithub.ServiceendpointGithubAuthOauth")]
    public interface IServiceendpointGithubAuthOauth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_github#oauth_configuration_id ServiceendpointGithub#oauth_configuration_id}.</summary>
        [JsiiProperty(name: "oauthConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
        string OauthConfigurationId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointGithubAuthOauth), fullyQualifiedName: "azuredevops.serviceendpointGithub.ServiceendpointGithubAuthOauth")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointGithub.IServiceendpointGithubAuthOauth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_github#oauth_configuration_id ServiceendpointGithub#oauth_configuration_id}.</summary>
            [JsiiProperty(name: "oauthConfigurationId", typeJson: "{\"primitive\":\"string\"}")]
            public string OauthConfigurationId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
