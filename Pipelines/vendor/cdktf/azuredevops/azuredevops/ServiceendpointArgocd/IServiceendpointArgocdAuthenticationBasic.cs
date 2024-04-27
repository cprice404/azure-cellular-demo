using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointArgocd
{
    [JsiiInterface(nativeType: typeof(IServiceendpointArgocdAuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationBasic")]
    public interface IServiceendpointArgocdAuthenticationBasic
    {
        /// <summary>The ArgoCD password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#password ServiceendpointArgocd#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>The ArgoCD user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#username ServiceendpointArgocd#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointArgocdAuthenticationBasic), fullyQualifiedName: "azuredevops.serviceendpointArgocd.ServiceendpointArgocdAuthenticationBasic")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointArgocd.IServiceendpointArgocdAuthenticationBasic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ArgoCD password.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#password ServiceendpointArgocd#password}
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ArgoCD user name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_argocd#username ServiceendpointArgocd#username}
            /// </remarks>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
