using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogPlatformV2
{
    [JsiiInterface(nativeType: typeof(IServiceendpointJfrogPlatformV2AuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointJfrogPlatformV2.ServiceendpointJfrogPlatformV2AuthenticationToken")]
    public interface IServiceendpointJfrogPlatformV2AuthenticationToken
    {
        /// <summary>The JFrog Artifactory access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_platform_v2#token ServiceendpointJfrogPlatformV2#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointJfrogPlatformV2AuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointJfrogPlatformV2.ServiceendpointJfrogPlatformV2AuthenticationToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointJfrogPlatformV2.IServiceendpointJfrogPlatformV2AuthenticationToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The JFrog Artifactory access token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_platform_v2#token ServiceendpointJfrogPlatformV2#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
