namespace PipelinesGenerator;

public record struct ApplicationComponent(
    String PipelineName,
    String Directory,
    ApplicationComponent.PipelineDefinition Definition
)
{
    public abstract class PipelineBuildStage
    {
        public class MakeStage : PipelineBuildStage
        {
            public override PipelineStage ToPipelineStage(string stageName, string displayName, string? dependsOn)
            {
                return new PipelineStage(
                    stageName,
                    displayName,
                    dependsOn,
                    new List<PipelineJob>
                    {
                        new(
                            stageName,
                            displayName,
                            new PipelineJobPool("ubuntu-latest"),
                            new List<PipelineStep>
                            {
                                new PipelineStep.CmdLine2(@"
echo ""This step would typically call 'make', but any build steps could go here.""
ls -l
")
                            }
                        )
                    }
                );
            }
        }
        
        private PipelineBuildStage() { }
        
        public abstract PipelineStage ToPipelineStage(string stageName, string displayName, string? dependsOn);
    }
    
    
    public abstract class PipelineReleaseStage
    {
        public class NoopStage : PipelineReleaseStage
        {
            public override PipelineStage ToPipelineStage(string stageName, string displayName, string? dependsOn)
            {
                return new PipelineStage(
                    stageName,
                    displayName,
                    dependsOn,
                    new List<PipelineJob>
                    {
                        new(
                            stageName,
                            displayName,
                            new PipelineJobPool("ubuntu-latest"),
                            new List<PipelineStep>
                            {
                                new PipelineStep.CmdLine2(@"
echo ""This project has no release artifacts; no-op.""
ls -l
")
                            }
                        )
                    }
                );

            }
        }

        public class BuildAndPushAcrImageStage : PipelineReleaseStage
        {
            public override PipelineStage ToPipelineStage(string stageName, string displayName, string? dependsOn)
            {
                return new PipelineStage(
                    stageName,
                    displayName,
                    dependsOn,
                    new List<PipelineJob>
                    {
                        new(
                            stageName,
                            displayName,
                            new PipelineJobPool("ubuntu-latest"),
                            new List<PipelineStep>
                            {
                                new PipelineStep.CmdLine2(@"
echo ""Here we would run commands to build and push a docker image to ACR; e.g. `docker build`, `acr login`, `docker push`.""
ls -l
")
                            }
                        )
                    }
                );
            }
        }
        
        private PipelineReleaseStage() { }
        
        public abstract PipelineStage ToPipelineStage(string stageName, string displayName, string? dependsOn);
    }

    public abstract class PipelineCellDeployStep
    {
        public class CdkTfDeployStep : PipelineCellDeployStep
        {
            public override List<PipelineStep> ToPipelineSteps()
            {
                return new List<PipelineStep>
                {
                    new PipelineStep.CmdLine2(@"
echo ""Here we would run commands to deploy infrastructure via CDK for TerraForm.""
ls -l
")
                };
            }
        }

        public class AksApplyManifestStep : PipelineCellDeployStep
        {
            public AksApplyManifestStep(string manifestPath)
            {
                ManifestPath = manifestPath;
            }

            public string ManifestPath { get; set; }
            
            public override List<PipelineStep> ToPipelineSteps()
            {
                return new List<PipelineStep>
                {
                    new PipelineStep.CmdLine2($@"
echo ""Here we would run commands to apply a k8s manifest, e.g. `kubectl apply -f {ManifestPath}`.""
ls -l
")
                };

            }
        }

        public class ShellCommandStep : PipelineCellDeployStep
        {
            public ShellCommandStep(string shellCommand)
            {
                ShellCommand = shellCommand;
            }

            public string ShellCommand { get; set; }
            
            public override List<PipelineStep> ToPipelineSteps()
            {
                return new List<PipelineStep>
                {
                    new PipelineStep.CmdLine2($@"
echo ""Here we would run arbitrary shell commands passed to the constructor, e.g. `{ShellCommand}`.""
ls -l
")
                };
            }
        }
        
        private PipelineCellDeployStep() { }

        public abstract List<PipelineStep> ToPipelineSteps();
    }

    public record struct PipelineDefinition(
        PipelineBuildStage BuildStage,
        PipelineReleaseStage ReleaseStage,
        PipelineCellDeployStep[] CellDeploySteps
    )
    {
        public List<PipelineStage> ToPipelineStages()
        {
            List<PipelineStage> stages = new();
            
            stages.Add(BuildStage.ToPipelineStage("BuildStage", "Build", null));
            stages.Add(ReleaseStage.ToPipelineStage("ReleaseStage", "Release", "BuildStage"));
            string prevStageName = "ReleaseStage";
            // int nextCellDeployStageIndex = 0;
            
                // nextCellDeployStageIndex++;
                // var stageName = $"CellDeployStage{nextCellDeployStageIndex}";
                // stages.Add(cellDeploySteps.ToPipelineStage(stageName, prevStageName));
                // prevStageName = stageName;
            // }
            var cellDeployStage = new PipelineStage(
                "CellDeployStage",
                "Deploy to Cells (Wave 1)",
                prevStageName,
                new List<PipelineJob>
                {
                    new(
                        "CellDeployCell1",
                        "Cell 1 Deploy",
                        new PipelineJobPool("ubuntu-latest"),
                        CellDeploySteps.SelectMany(s => s.ToPipelineSteps()).ToList()
                    )
                }
            );
            stages.Add(cellDeployStage);
            
            return stages;
        }
    }
}