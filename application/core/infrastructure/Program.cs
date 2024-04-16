using System;
using cell_registry;
using CoreInfrastructure;
using HashiCorp.Cdktf;

namespace MyCompany.MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ICellRegistry cellRegistry = CellRegistry.Default();
            
            App app = new App();
            new CoreInfrastructureStack(app, "core-infrastructure");
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}