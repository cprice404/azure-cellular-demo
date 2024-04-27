using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointMaven
{
    [JsiiInterface(nativeType: typeof(IServiceendpointMavenAuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointMaven.ServiceendpointMavenAuthenticationToken")]
    public interface IServiceendpointMavenAuthenticationToken
    {
        /// <summary>The Maven access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#token ServiceendpointMaven#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointMavenAuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointMaven.ServiceendpointMavenAuthenticationToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointMaven.IServiceendpointMavenAuthenticationToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Maven access token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_maven#token ServiceendpointMaven#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
