using System.Diagnostics;
using System.Text.Json;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using cell_registry;

class HardCodedCellRegistry : ICellRegistry
{
    private readonly Dictionary<String, Cell> cells = new();
    
    internal HardCodedCellRegistry()
    {
        var developerChrisSubscriptionId = "5cf20061-1947-49d1-915b-4c0345485985";
        cells.Add(developerChrisSubscriptionId, new Cell(developerChrisSubscriptionId, "developer-chris", CellType.DEVELOPER));
    }


    public Cell GetCellBySubscriptionId(string subscriptionId)
    {
        return cells[subscriptionId];
    }

    public Cell GetCellForCurrentSubscription()
    {
        // var credential = new DefaultAzureCredential();
        // ArmClient client = new ArmClient(credential);
        // SubscriptionResource subscription = client.GetDefaultSubscription();
        // Console.WriteLine($"Default Subscription ID: {subscription.Data.SubscriptionId}");
        //
        // var subscriptions = client.GetSubscriptions();
        // Console.WriteLine($"All subscriptions: {string.Join(", ", subscriptions.Select(s => s.Data.SubscriptionId))}");
        //
        // throw new NotImplementedException();
        string defaultSubscriptionId = GetDefaultAzureSubscriptionId();
        return cells[defaultSubscriptionId];
    }
    
    private static string GetDefaultAzureSubscriptionId()
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = "az",
            Arguments = "account show",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (var process = new Process { StartInfo = startInfo })
        {
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                string error = process.StandardError.ReadToEnd();
                throw new Exception($"Error executing 'az account show': {error}");
            }

            using (var jsonDocument = JsonDocument.Parse(output))
            {
                JsonElement root = jsonDocument.RootElement;
                if (root.TryGetProperty("id", out JsonElement idElement))
                {
                    string subscriptionId = idElement.GetString();
                    return subscriptionId;
                }
                else
                {
                    throw new Exception("Unable to find the 'id' property in the JSON output.");
                }
            }
        }
    }
}