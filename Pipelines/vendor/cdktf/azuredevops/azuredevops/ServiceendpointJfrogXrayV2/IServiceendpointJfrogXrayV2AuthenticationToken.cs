using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogXrayV2
{
    [JsiiInterface(nativeType: typeof(IServiceendpointJfrogXrayV2AuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointJfrogXrayV2.ServiceendpointJfrogXrayV2AuthenticationToken")]
    public interface IServiceendpointJfrogXrayV2AuthenticationToken
    {
        /// <summary>The JFrog Artifactory access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_xray_v2#token ServiceendpointJfrogXrayV2#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointJfrogXrayV2AuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointJfrogXrayV2.ServiceendpointJfrogXrayV2AuthenticationToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointJfrogXrayV2.IServiceendpointJfrogXrayV2AuthenticationToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The JFrog Artifactory access token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_xray_v2#token ServiceendpointJfrogXrayV2#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
