using System.Diagnostics;
using System.Text.Json;

namespace CellRegistry;

internal class HardCodedCellRegistry : ICellRegistry
{
    private readonly Dictionary<String, Cell> cells = new();
    
    internal HardCodedCellRegistry()
    {
        var developerChrisSubscriptionId = "7c6aa098-eff7-4553-8f9e-3ce1c045c8c9";
        cells.Add(developerChrisSubscriptionId, new Cell(
            SubscriptionId: developerChrisSubscriptionId,
            CellName: "developerchris",
            CellType: CellType.DEVELOPER,
            BackendStorageContainer: new AzureBackendStorageContainer(
                ResourceGroupName: "cdktf-state",
                StorageAccountName: "cdktfstate187",
                ContainerName: "cdktf-state"
            ),
            Location: "westus2"
        ));
        cells.Add("fake-alpha-subscription-id", new Cell(
            SubscriptionId: "fake-alpha-subscription-id",
            CellName: "alpha",
            CellType: CellType.PREPROD,
            BackendStorageContainer: new AzureBackendStorageContainer(
                ResourceGroupName: "cdktf-state",
                StorageAccountName: "cdktfstate90210",
                ContainerName: "cdktf-state"
            ),
            Location: "westus2"
        ));
        
        cells.Add("fake-westus2-1-subscription-id", new Cell(
            SubscriptionId: "fake-westus2-1-subscription-id",
            CellName: "westus2_1",
            CellType: CellType.PROD,
            BackendStorageContainer: new AzureBackendStorageContainer(
                ResourceGroupName: "cdktf-state",
                StorageAccountName: "cdktfstate90211",
                ContainerName: "cdktf-state"
            ),
            Location: "westus2"
        ));
        
        cells.Add("fake-eastus1-1-subscription-id", new Cell(
            SubscriptionId: "fake-eastus1-1-subscription-id",
            CellName: "eastus1_1",
            CellType: CellType.PROD,
            BackendStorageContainer: new AzureBackendStorageContainer(
                ResourceGroupName: "cdktf-state",
                StorageAccountName: "cdktfstate90212",
                ContainerName: "cdktf-state"
            ),
            Location: "eastus1"
        ));
        
        cells.Add("fake-southcentralus-1-subscription-id", new Cell(
            SubscriptionId: "fake-southcentralus-1-subscription-id",
            CellName: "southcentralus_1",
            CellType: CellType.PROD,
            BackendStorageContainer: new AzureBackendStorageContainer(
                ResourceGroupName: "cdktf-state",
                StorageAccountName: "cdktfstate90213",
                ContainerName: "cdktf-state"
            ),
            Location: "southcentralus"
        ));
        
        cells.Add("fake-westus3-1-subscription-id", new Cell(
            SubscriptionId: "fake-westus3-1-subscription-id",
            CellName: "westus3_1",
            CellType: CellType.PROD,
            BackendStorageContainer: new AzureBackendStorageContainer(
                ResourceGroupName: "cdktf-state",
                StorageAccountName: "cdktfstate90214",
                ContainerName: "cdktf-state"
            ),
            Location: "westus3"
        ));
    }


    public Cell GetCellBySubscriptionId(string subscriptionId)
    {
        return cells[subscriptionId];
    }
    
    public Cell GetCellByName(string cellName)
    {
        return cells.Values.First(cell => cell.CellName == cellName);
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
    
    public string CoreInfrastructureResourceGroupName => "azure-cellular-demo-core-infra-rg";

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