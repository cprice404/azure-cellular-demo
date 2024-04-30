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

record struct PipelineRoot(
    PipelineTrigger Trigger,
    List<PipelineResources> Resources
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
            }
        );
    }
}
