using System;
using System.Diagnostics;
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
            
            String version = GetVersion();

            App app = new App();
            new HelloServiceInfrastructureStack(app, "infrastructure", new HelloServiceInfrastructureStack.Options(
                BackendStorageContainer: cell.BackendStorageContainer,
                Location: cell.Location,
                CellName: cell.CellName,
                CoreInfrastructureResourceGroupName: cellRegistry.CoreInfrastructureResourceGroupName,
                HelloServiceVersion: version
            ));
            app.Synth();
            Console.WriteLine("App synth complete");
        }
        
        private static String GetVersion()
        {
            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "rev-list --count HEAD",
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };
            var proc = Process.Start(startInfo);
            ArgumentNullException.ThrowIfNull(proc);
            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            return output;
        }
    }
}