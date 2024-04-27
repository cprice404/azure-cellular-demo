using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArtifactory
{
    [JsiiInterface(nativeType: typeof(IServiceendpointArtifactoryAuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationToken")]
    public interface IServiceendpointArtifactoryAuthenticationToken
    {
        /// <summary>The Artifactory access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#token ServiceendpointArtifactory#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointArtifactoryAuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Artifactory access token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#token ServiceendpointArtifactory#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
