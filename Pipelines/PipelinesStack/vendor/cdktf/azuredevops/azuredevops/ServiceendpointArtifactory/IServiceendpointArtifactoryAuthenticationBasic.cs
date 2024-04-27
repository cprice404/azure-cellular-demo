using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArtifactory
{
    [JsiiInterface(nativeType: typeof(IServiceendpointArtifactoryAuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationBasic")]
    public interface IServiceendpointArtifactoryAuthenticationBasic
    {
        /// <summary>The Artifactory password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#password ServiceendpointArtifactory#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>The Artifactory user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#username ServiceendpointArtifactory#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointArtifactoryAuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointArtifactory.ServiceendpointArtifactoryAuthenticationBasic")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointArtifactory.IServiceendpointArtifactoryAuthenticationBasic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Artifactory password.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#password ServiceendpointArtifactory#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Artifactory user name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_artifactory#username ServiceendpointArtifactory#username}
            /// </remarks>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
