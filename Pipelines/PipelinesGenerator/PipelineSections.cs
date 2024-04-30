using YamlDotNet.Serialization;

public record struct PipelineTriggerBranches(
    List<string> Include
);

public record struct PipelineTriggerPaths(
    List<string> Include
);

public record struct PipelineTrigger(
    PipelineTriggerBranches Branches,
    PipelineTriggerPaths Paths
);

public record struct PipelineResources(
    string Repo
);


public record PipelineStep
{
    public PipelineStep(string task) { Task = task; }
    
    [YamlMember(Order = 0)]
    public string Task { get; init; }
    
    public record CmdLine2 : PipelineStep
    {
        public record CmdLine2Inputs
        {
            public CmdLine2Inputs(string script) { Script = script; }
            
            [YamlMember(ScalarStyle = YamlDotNet.Core.ScalarStyle.Literal)]
            public string Script { get; init; }
        }
        public CmdLine2(string script) : base("CmdLine@2") { Inputs = new CmdLine2Inputs(script); }
        
        [YamlMember(Order = 1)]
        public CmdLine2Inputs Inputs { get; init; }
    }
};

public record struct PipelineJobPool(
    string VmImage
);

public record struct PipelineJob(
    string Job,
    string DisplayName,
    PipelineJobPool Pool,
    List<PipelineStep> Steps
);

public record struct PipelineStage(
    string Stage,
    string DisplayName,
    string? DependsOn,
    List<PipelineJob> Jobs
);



public record struct PipelineRoot(
    PipelineTrigger Trigger,
    List<PipelineResources> Resources,
    List<PipelineStage> Stages
);