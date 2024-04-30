public class BuildStages
{
    public static PipelineStage Build()
    {
        return new PipelineStage(
            "Build",
            "Build",
            null,
            new List<PipelineJob>
            {
                new PipelineJob(
                    "Build",
                    "Build",
                    new PipelineJobPool("ubuntu-latest"),
                    new List<PipelineStep>
                    {
                        new PipelineStep.CmdLine2(@"
echo ""Any build steps could go here.""
ls -l
")
                    }
                )
            }
        );
    }

    public static PipelineStage Release()
    {
        return new PipelineStage(
            "Release",
            "Release",
            "Build",
            new List<PipelineJob>
            {
                new PipelineJob(
                    "Release",
                    "Release",
                    new PipelineJobPool("ubuntu-latest"),
                    new List<PipelineStep>
                    {
                        new PipelineStep.CmdLine2(@"
echo ""Any build steps could go here.""
ls -l
")
                    }
                )
            }
        );
    }
}