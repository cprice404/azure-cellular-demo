using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithubEnterprise
{
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonalOutputReference), fullyQualifiedName: "azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonalOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceendpointGithubEnterpriseAuthPersonalOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceendpointGithubEnterpriseAuthPersonalOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointGithubEnterpriseAuthPersonalOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointGithubEnterpriseAuthPersonalOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "personalAccessTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersonalAccessTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "personalAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersonalAccessToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonal\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthPersonal? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthPersonal?>();
            set => SetInstanceProperty(value);
        }
    }
}
