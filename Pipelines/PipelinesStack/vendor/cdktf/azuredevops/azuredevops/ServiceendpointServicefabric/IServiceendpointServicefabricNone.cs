using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointServicefabric
{
    [JsiiInterface(nativeType: typeof(IServiceendpointServicefabricNone), fullyQualifiedName: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricNone")]
    public interface IServiceendpointServicefabricNone
    {
        /// <summary>Fully qualified domain SPN for gMSA account. This is applicable only if `unsecured` option is disabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#cluster_spn ServiceendpointServicefabric#cluster_spn}
        /// </remarks>
        [JsiiProperty(name: "clusterSpn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterSpn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip using windows security for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#unsecured ServiceendpointServicefabric#unsecured}
        /// </remarks>
        [JsiiProperty(name: "unsecured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Unsecured
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceendpointServicefabricNone), fullyQualifiedName: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricNone")]
        internal sealed class _Proxy : DeputyBase, azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Fully qualified domain SPN for gMSA account. This is applicable only if `unsecured` option is disabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#cluster_spn ServiceendpointServicefabric#cluster_spn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterSpn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterSpn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Skip using windows security for authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/serviceendpoint_servicefabric#unsecured ServiceendpointServicefabric#unsecured}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unsecured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Unsecured
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
