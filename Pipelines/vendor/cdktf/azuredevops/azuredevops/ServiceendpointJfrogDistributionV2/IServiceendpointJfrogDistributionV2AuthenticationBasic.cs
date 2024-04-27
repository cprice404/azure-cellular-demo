using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointJfrogDistributionV2
{
    [JsiiInterface(nativeType: typeof(IServiceendpointJfrogDistributionV2AuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2AuthenticationBasic")]
    public interface IServiceendpointJfrogDistributionV2AuthenticationBasic
    {
        /// <summary>The JFrog Artifactory password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#password ServiceendpointJfrogDistributionV2#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>The JFrog Artifactory user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#username ServiceendpointJfrogDistributionV2#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointJfrogDistributionV2AuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointJfrogDistributionV2.ServiceendpointJfrogDistributionV2AuthenticationBasic")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointJfrogDistributionV2.IServiceendpointJfrogDistributionV2AuthenticationBasic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The JFrog Artifactory password.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#password ServiceendpointJfrogDistributionV2#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The JFrog Artifactory user name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_jfrog_distribution_v2#username ServiceendpointJfrogDistributionV2#username}
            /// </remarks>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
