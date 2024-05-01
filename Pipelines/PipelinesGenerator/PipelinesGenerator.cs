using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace PipelinesGenerator;

public class PipelinesGenerator
{
    public void GeneratePipelines()
    {
        string outputDirectory = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "generated-pipeline-yml/");
        Directory.CreateDirectory(outputDirectory);
        foreach (var applicationComponent in ApplicationComponents.AllComponents)
        {
            string pipelineYmlFile = Path.Join(outputDirectory, $"{applicationComponent.PipelineName}.yml");
            Console.WriteLine($"Generating pipeline '{applicationComponent.PipelineName}'; source path: {applicationComponent.Directory}, target path: {pipelineYmlFile}");
            File.WriteAllText(pipelineYmlFile, GeneratePipelineYml(applicationComponent));
        }
    }
    
    
    private string GeneratePipelineYml(ApplicationComponent applicationComponent)
    {
        var pipelineRoot = CreatePipeline(applicationComponent);
        var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .DisableAliases()
            .Build();
        return serializer.Serialize(pipelineRoot);
    }

    private PipelineRoot CreatePipeline(ApplicationComponent applicationComponent)
    {
        return new PipelineRoot(
            new PipelineTrigger(
                new PipelineTriggerBranches(
                    new List<string> { "main" }
                ),
                new PipelineTriggerPaths(
                    new List<string> { $"/{applicationComponent.Directory}/**" }
                )
            ),
            new List<PipelineResources>
            {
                new("self")
            },
            applicationComponent.Definition.ToPipelineStages()
        );
    }
}