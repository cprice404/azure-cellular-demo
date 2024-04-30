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
            File.WriteAllText(pipelineYmlFile, this.GeneratePipelineYml(applicationComponent.Directory));
        }
    }
    
    
    private string GeneratePipelineYml(string path)
    {
        var pipelineRoot = PipelineRoot.Create(path);
        var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
        return serializer.Serialize(pipelineRoot);
    }
    /*
     * trigger:
         branches:
           include:
             - main
         paths:
           include:
             - '/Pipelines/**'
       resources:
         - repo: self
     */
    /*
     * 
       
        var person = new Person
       {
           Name = "Abe Lincoln",
           Age = 25,
           HeightInInches = 6f + 4f / 12f,
           Addresses = new Dictionary<string, Address>{
               { "home", new  Address() {
                       Street = "2720  Sundown Lane",
                       City = "Kentucketsville",
                       State = "Calousiyorkida",
                       Zip = "99978",
                   }},
               { "work", new  Address() {
                       Street = "1600 Pennsylvania Avenue NW",
                       City = "Washington",
                       State = "District of Columbia",
                       Zip = "20500",
                   }},
           }
       };
       
       var serializer = new SerializerBuilder()
           .WithNamingConvention(CamelCaseNamingConvention.Instance)
           .Build();
       var yaml = serializer.Serialize(person);
       System.Console.WriteLine(yaml);
     */
    
}