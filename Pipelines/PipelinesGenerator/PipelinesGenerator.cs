namespace PipelinesGenerator;

public class PipelinesGenerator
{
    public void GeneratePipelines()
    {
        string outputDirectory = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "generated-pipeline-yml/");
        Directory.CreateDirectory(outputDirectory);
        foreach (var applicationComponent in ApplicationComponents.AllComponents)
        {
            string pipelineYmlFile = Path.Join(outputDirectory, $"{applicationComponent.PipelineName}.yml");
            Console.WriteLine($"Generating pipeline '{applicationComponent.PipelineName}'; source path: {applicationComponent.Directory}, target path: {pipelineYmlFile}");
            File.WriteAllText(pipelineYmlFile, "Hello World!");
        }
    }
}