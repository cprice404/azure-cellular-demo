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

    public abstract class PipelineCellDeployStage
    {
        public class CdkTfDeployStage : PipelineCellDeployStage
        {
            public override PipelineStage ToPipelineStage(string stageName, string dependsOn)
            {
                return new PipelineStage(
                    stageName,
                    "cdktf deploy",
                    dependsOn,
                    new List<PipelineJob>
                    {
                        new(
                            stageName,
                            "cdktf deploy",
                            new PipelineJobPool("ubuntu-latest"),
                            new List<PipelineStep>
                            {
                                new PipelineStep.CmdLine2(@"
echo ""Here we would run commands to deploy infrastructure via CDK for TerraForm.""
ls -l
")
                            }
                        )
                    }
                );

            }
        }

        public class AksApplyManifestStage : PipelineCellDeployStage
        {
            public AksApplyManifestStage(string manifestPath)
            {
                ManifestPath = manifestPath;
            }

            public string ManifestPath { get; set; }
            
            public override PipelineStage ToPipelineStage(string stageName, string dependsOn)
            {
                return new PipelineStage(
                    stageName,
                    "kubectl apply",
                    dependsOn,
                    new List<PipelineJob>
                    {
                        new(
                            stageName,
                            "kubectl apply",
                            new PipelineJobPool("ubuntu-latest"),
                            new List<PipelineStep>
                            {
                                new PipelineStep.CmdLine2($@"
echo ""Here we would run commands to apply a k8s manifest, e.g. `kubectl apply -f {ManifestPath}`.""
ls -l
")
                            }
                        )
                    }
                );
            }
        }

        public class ShellCommandStage : PipelineCellDeployStage
        {
            public ShellCommandStage(string shellCommand)
            {
                ShellCommand = shellCommand;
            }

            public string ShellCommand { get; set; }
            
            public override PipelineStage ToPipelineStage(string stageName, string dependsOn)
            {
                return new PipelineStage(
                    stageName,
                    "Shell Command",
                    dependsOn,
                    new List<PipelineJob>
                    {
                        new(
                            stageName,
                            "Shell Command",
                            new PipelineJobPool("ubuntu-latest"),
                            new List<PipelineStep>
                            {
                                new PipelineStep.CmdLine2($@"
echo ""Here we would run arbitrary shell commands passed to the constructor, e.g. `{ShellCommand}`.""
ls -l
")
                            }
                        )
                    }
                );

            }
        }
        
        private PipelineCellDeployStage() { }
        
        public abstract PipelineStage ToPipelineStage(string stageName, string dependsOn);
    }

    public record struct PipelineDefinition(
        PipelineBuildStage BuildStage,
        PipelineReleaseStage ReleaseStage,
        PipelineCellDeployStage[] CellDeployStages
    )
    {
        public List<PipelineStage> ToPipelineStages()
        {
            List<PipelineStage> stages = new();
            
            stages.Add(BuildStage.ToPipelineStage("BuildStage", "Build", null));
            stages.Add(ReleaseStage.ToPipelineStage("ReleaseStage", "Release", "BuildStage"));
            string prevStageName = "ReleaseStage";
            int nextCellDeployStageIndex = 0;
            foreach (var cellDeployStage in CellDeployStages)
            {
                nextCellDeployStageIndex++;
                var stageName = $"CellDeployStage{nextCellDeployStageIndex}";
                stages.Add(cellDeployStage.ToPipelineStage(stageName, prevStageName));
                prevStageName = stageName;
            }
            
            return stages;
        }
    }
}