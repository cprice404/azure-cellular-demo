using System;
using CellRegistry;
using CoreInfrastructure;
using HashiCorp.Cdktf;

namespace MyCompany.MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ICellRegistry cellRegistry = CellRegistry.CellRegistry.Default();
            Cell cell = cellRegistry.GetCellForCurrentSubscription();
            
            App app = new App();
            new CoreInfrastructureStack(app, "core-infrastructure", cell.BackendStorageContainer, cell.Location);
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}