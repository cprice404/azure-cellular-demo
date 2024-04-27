using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogArtifactoryV2
{
    [JsiiInterface(nativeType: typeof(IServiceendpointJfrogArtifactoryV2AuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationToken")]
    public interface IServiceendpointJfrogArtifactoryV2AuthenticationToken
    {
        /// <summary>The JFrog Artifactory access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_artifactory_v2#token ServiceendpointJfrogArtifactoryV2#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointJfrogArtifactoryV2AuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointJfrogArtifactoryV2.ServiceendpointJfrogArtifactoryV2AuthenticationToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointJfrogArtifactoryV2.IServiceendpointJfrogArtifactoryV2AuthenticationToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The JFrog Artifactory access token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_artifactory_v2#token ServiceendpointJfrogArtifactoryV2#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
