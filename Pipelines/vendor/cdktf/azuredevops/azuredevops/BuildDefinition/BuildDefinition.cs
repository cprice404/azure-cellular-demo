using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.BuildDefinition
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition azuredevops_build_definition}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.BuildDefinition.BuildDefinition), fullyQualifiedName: "azuredevops.buildDefinition.BuildDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionConfig\"}}]")]
    public class BuildDefinition : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition azuredevops_build_definition} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BuildDefinition(Constructs.Construct scope, string id, azuredevops.BuildDefinition.IBuildDefinitionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.BuildDefinition.IBuildDefinitionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BuildDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BuildDefinition(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a BuildDefinition resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BuildDefinition to import.</param>
        /// <param name="importFromId">The id of the existing BuildDefinition that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BuildDefinition to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BuildDefinition to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.0.1/docs/resources/build_definition#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BuildDefinition that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BuildDefinition to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azuredevops.BuildDefinition.BuildDefinition), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCiTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTrigger\"}}]")]
        public virtual void PutCiTrigger(azuredevops.BuildDefinition.IBuildDefinitionCiTrigger @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.BuildDefinition.IBuildDefinitionCiTrigger)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFeatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionFeatures\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFeatures(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azuredevops.BuildDefinition.IBuildDefinitionFeatures[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionFeatures).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionFeatures).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPullRequestTrigger", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger\"}}]")]
        public virtual void PutPullRequestTrigger(azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepository", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionRepository\"}}]")]
        public virtual void PutRepository(azuredevops.BuildDefinition.IBuildDefinitionRepository @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.BuildDefinition.IBuildDefinitionRepository)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionSchedules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSchedules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azuredevops.BuildDefinition.IBuildDefinitionSchedules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionSchedules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionSchedules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVariable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionVariable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVariable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azuredevops.BuildDefinition.IBuildDefinitionVariable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionVariable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azuredevops.BuildDefinition.IBuildDefinitionVariable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAgentPoolName")]
        public virtual void ResetAgentPoolName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCiTrigger")]
        public virtual void ResetCiTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatures")]
        public virtual void ResetFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPullRequestTrigger")]
        public virtual void ResetPullRequestTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueueStatus")]
        public virtual void ResetQueueStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedules")]
        public virtual void ResetSchedules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVariable")]
        public virtual void ResetVariable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVariableGroups")]
        public virtual void ResetVariableGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azuredevops.BuildDefinition.BuildDefinition))!;

        [JsiiProperty(name: "ciTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTriggerOutputReference\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionCiTriggerOutputReference CiTrigger
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionCiTriggerOutputReference>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionFeaturesList\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionFeaturesList Features
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionFeaturesList>()!;
        }

        [JsiiProperty(name: "pullRequestTrigger", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTriggerOutputReference\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerOutputReference PullRequestTrigger
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionPullRequestTriggerOutputReference>()!;
        }

        [JsiiProperty(name: "repository", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionRepositoryOutputReference\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionRepositoryOutputReference Repository
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionRepositoryOutputReference>()!;
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Revision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "schedules", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionSchedulesList\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionSchedulesList Schedules
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionSchedulesList>()!;
        }

        [JsiiProperty(name: "variable", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionVariableList\"}")]
        public virtual azuredevops.BuildDefinition.BuildDefinitionVariableList Variable
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.BuildDefinitionVariableList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentPoolNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgentPoolNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ciTriggerInput", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionCiTrigger\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionCiTrigger? CiTriggerInput
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionCiTrigger?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FeaturesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pullRequestTriggerInput", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionPullRequestTrigger\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger? PullRequestTriggerInput
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionPullRequestTrigger?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queueStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueueStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryInput", typeJson: "{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionRepository\"}", isOptional: true)]
        public virtual azuredevops.BuildDefinition.IBuildDefinitionRepository? RepositoryInput
        {
            get => GetInstanceProperty<azuredevops.BuildDefinition.IBuildDefinitionRepository?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionSchedules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SchedulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "variableGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? VariableGroupsInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "variableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuredevops.buildDefinition.BuildDefinitionVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VariableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "agentPoolName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentPoolName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queueStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "variableGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] VariableGroups
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
