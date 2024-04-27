using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithub
{
    [JsiiInterface(nativeType: typeof(IServiceendpointGithubAuthPersonal), fullyQualifiedName: "azuredevops.serviceendpointGithub.ServiceendpointGithubAuthPersonal")]
    public interface IServiceendpointGithubAuthPersonal
    {
        /// <summary>The GitHub personal access token which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_github#personal_access_token ServiceendpointGithub#personal_access_token}
        /// </remarks>
        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        string PersonalAccessToken
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointGithubAuthPersonal), fullyQualifiedName: "azuredevops.serviceendpointGithub.ServiceendpointGithubAuthPersonal")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointGithub.IServiceendpointGithubAuthPersonal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The GitHub personal access token which should be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_github#personal_access_token ServiceendpointGithub#personal_access_token}
            /// </remarks>
            [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
            public string PersonalAccessToken
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
