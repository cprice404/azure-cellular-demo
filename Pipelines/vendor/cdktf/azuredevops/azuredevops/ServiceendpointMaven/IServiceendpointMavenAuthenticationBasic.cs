using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointMaven
{
    [JsiiInterface(nativeType: typeof(IServiceendpointMavenAuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointMaven.ServiceendpointMavenAuthenticationBasic")]
    public interface IServiceendpointMavenAuthenticationBasic
    {
        /// <summary>The Maven password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#password ServiceendpointMaven#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>The Maven user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#username ServiceendpointMaven#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointMavenAuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointMaven.ServiceendpointMavenAuthenticationBasic")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointMaven.IServiceendpointMavenAuthenticationBasic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Maven password.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#password ServiceendpointMaven#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Maven user name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#username ServiceendpointMaven#username}
            /// </remarks>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
