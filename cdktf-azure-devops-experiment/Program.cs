using System;
using System.IO;
using Constructs;
using HashiCorp.Cdktf;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace MyCompany.MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var config =
                new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", false)
                    .Build();

            
            String azureDevopsOrganizationUrl = getConfig(config, "AzureDevopsOrganizationUrl");
            String azurePersonalAccessToken = getConfig(config, "AzureDevopsPersonalAccessToken");
            String githubPersonalAccessToken = getConfig(config, "GithubPersonalAccessToken");
            
            
            App app = new App();
            new MainStack(app, "cdktf-azure-devops-experiment", new MainStackOptions()
            {
                azureDevopsOrganizationUrl = azureDevopsOrganizationUrl,
                azureDevopsPersonalAccessToken = azurePersonalAccessToken,
                githubPersonalAccessToken = githubPersonalAccessToken,
            });
            app.Synth();
            Console.WriteLine("App synth complete");
        }

        private static String getConfig(IConfigurationRoot config, String configKey)
        {
            return config.GetValue<String>(configKey) ??
                throw new ArgumentNullException(
                    $"appsettings.json missing required field '{configKey}'");

        }
    }
}