using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArgocd
{
    [JsiiInterface(nativeType: typeof(IServiceendpointArgocdAuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationToken")]
    public interface IServiceendpointArgocdAuthenticationToken
    {
        /// <summary>The ArgoCD access token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#token ServiceendpointArgocd#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointArgocdAuthenticationToken), fullyQualifiedName: "azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationToken")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ArgoCD access token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#token ServiceendpointArgocd#token}
            /// </remarks>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
