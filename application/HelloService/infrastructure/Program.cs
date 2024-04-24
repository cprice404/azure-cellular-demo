using System;
using CellRegistry;
using HashiCorp.Cdktf;

namespace HelloServiceInfrastructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            ICellRegistry cellRegistry = CellRegistry.CellRegistry.Default();
            Cell cell = cellRegistry.GetCellForCurrentSubscription();

            App app = new App();
            new HelloServiceInfrastructureStack(app, "infrastructure", new HelloServiceInfrastructureStack.Options(
                BackendStorageContainer: cell.BackendStorageContainer,
                Location: cell.Location,
                CellName: cell.CellName,
                CoreInfrastructureResourceGroupName: cellRegistry.CoreInfrastructureResourceGroupName,
                HelloServiceVersion: "0.0.00"
            ));
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}