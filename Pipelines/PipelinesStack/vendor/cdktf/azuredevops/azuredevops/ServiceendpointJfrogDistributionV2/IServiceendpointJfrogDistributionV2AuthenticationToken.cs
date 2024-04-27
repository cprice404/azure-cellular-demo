using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogDistributionV2
{
    [JsiiInterface(nativeType: typeof(IServiceendpointJfrogDistributionV2AuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2AuthenticationToken")]
    public interface IServiceendpointJfrogDistributionV2AuthenticationToken
    {
        /// <summary>The JFrog Artifactory access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#token ServiceendpointJfrogDistributionV2#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointJfrogDistributionV2AuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2AuthenticationToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2AuthenticationToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The JFrog Artifactory access token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#token ServiceendpointJfrogDistributionV2#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
