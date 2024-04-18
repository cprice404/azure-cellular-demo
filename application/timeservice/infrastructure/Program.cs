using System;
using CellRegistry;
using HashiCorp.Cdktf;

namespace TimeServiceInfrastructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            ICellRegistry cellRegistry = CellRegistry.CellRegistry.Default();
            Cell cell = cellRegistry.GetCellForCurrentSubscription();

            App app = new App();
            new TimeServiceInfrastructureStack(app, "infrastructure", new TimeServiceInfrastructureStack.Options(
                BackendStorageContainer: cell.BackendStorageContainer,
                Location: cell.Location,
                CellName: cell.CellName
            ));
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}