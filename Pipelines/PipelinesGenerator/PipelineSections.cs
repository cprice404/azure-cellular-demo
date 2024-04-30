public record struct PipelineTriggerBranches(
    List<string> Include
);

public record struct PipelineTriggerPaths(
    List<string> Include
);

record struct PipelineTrigger(
    PipelineTriggerBranches Branches,
    PipelineTriggerPaths Paths
);

record struct PipelineResources(
    string Repo
);


record struct PipelineStep(
    string Task,
    Dictionary<string, string> Inputs
);

record struct PipelineJob(
    string Job,
    string DisplayName,
    string Pool,
    List<PipelineStep> Steps
);

record struct PipelineStage(
    string Stage,
    string DisplayName,
    string? DependsOn,
    List<PipelineJob> Jobs
);

record struct PipelineRoot(
    PipelineTrigger Trigger,
    List<PipelineResources> Resources,
    List<PipelineStage> Stages
)
{
    public static PipelineRoot Create(string path)
    {
        return new PipelineRoot(
            new PipelineTrigger(
                new PipelineTriggerBranches(
                    new List<string> { "main" }
                ),
                new PipelineTriggerPaths(
                    new List<string> { $"/{path}/**" }
                )
            ),
            new List<PipelineResources>
            {
                new PipelineResources("self")
            },
            new List<PipelineStage>
            {
                new PipelineStage(
                    "Build",
                    "Build",
                    null,
                    new List<PipelineJob>
                    {
                        new PipelineJob(
                            "Build",
                            "Build",
                            "vmImage: ubuntu-latest",
                            new List<PipelineStep>
                            {
                                new PipelineStep(
                                    "CmdLine@2",
                                    new Dictionary<string, string>
                                    {
                                        { "script", @"
echo ""Any build steps could go here.""
ls -l
" }
                                    }
                                )
                            }
                        )
                    }
                ),
                new PipelineStage(
                    "Release",
                    "Release",
                    "Build",
                    new List<PipelineJob>
                    {
                        new PipelineJob(
                            "Release",
                            "Release",
                            "vmImage: ubuntu-latest",
                            new List<PipelineStep>
                            {
                                new PipelineStep(
                                    "CmdLine@2",
                                    new Dictionary<string, string>
                                    {
                                        { "script", @"
echo ""Any build steps could go here.""
ls -l
" }
                                    }
                                )
                            }
                        )
                    }
                )

            }
        );
    }
}
