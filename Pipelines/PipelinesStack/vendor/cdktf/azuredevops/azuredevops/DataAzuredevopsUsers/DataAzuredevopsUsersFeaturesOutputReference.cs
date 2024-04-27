using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsUsers
{
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsUsers.DataAzuredevopsUsersFeaturesOutputReference), fullyQualifiedName: "azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersFeaturesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAzuredevopsUsersFeaturesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAzuredevopsUsersFeaturesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAzuredevopsUsersFeaturesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsUsersFeaturesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConcurrentWorkers")]
        public virtual void ResetConcurrentWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "concurrentWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConcurrentWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "concurrentWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConcurrentWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersFeatures\"}", isOptional: true)]
        public virtual azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersFeatures? InternalValue
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersFeatures?>();
            set => SetInstanceProperty(value);
        }
    }
}
