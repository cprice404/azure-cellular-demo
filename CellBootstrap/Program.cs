using CellRegistry;
using CommandLine;

namespace CellBootstrap
{
    [Verb("bootstrap", HelpText = "Bootstrap a new cell")]
    class BootstrapOptions
    {
        
    }

    [Verb("teardown", HelpText = "Tear down an existing cell")]
    class TearDownOptions
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<BootstrapOptions, TearDownOptions>(args)
                .MapResult(
                    (BootstrapOptions opts) => RunBootstrapAndReturnExitCode(opts),
                    (TearDownOptions opts) => RunTearDownAndReturnExitCode(opts),
                    errors => HandleErrorsAndReturnExitCode(errors)
                );
        }
        
        static int RunBootstrapAndReturnExitCode(BootstrapOptions opts)
        {
            ICellRegistry cellRegistry = CellRegistry.CellRegistry.Default();
            Cell cell = cellRegistry.GetCellForCurrentSubscription();
            
            DirectoryInfo cwd = Directory.GetParent(Directory.GetCurrentDirectory());
            foreach (ApplicationComponent appComponent in ApplicationComponents.GetAllComponents())
            {
                var appComponentPath = Path.Join(cwd.FullName, appComponent.PathFromRoot);
                Console.WriteLine("Running bootstrap for {0}", appComponentPath);
                int exitCode = ShellUtils.ExecuteShellCommand(
                    appComponentPath,
                    "make",
                    "cell-bootstrap",
                    new Dictionary<string, string>()
                    {
                        { "CELL_NAME", cell.CellName }
                    }
                );
                if (exitCode != 0)
                {
                    return exitCode;
                }
            }
            return 0;
            return 0;
        }
        
        static int RunTearDownAndReturnExitCode(TearDownOptions opts)
        {
            DirectoryInfo cwd = Directory.GetParent(Directory.GetCurrentDirectory());
            foreach (ApplicationComponent appComponent in Enumerable.Reverse(ApplicationComponents.GetAllComponents()))
            {
                var appComponentPath = Path.Join(cwd.FullName, appComponent.PathFromRoot);
                Console.WriteLine("Running teardown for {0}", appComponentPath);
                int exitCode = ShellUtils.ExecuteShellCommand(
                    appComponentPath, 
                    "make", 
                    "cell-teardown", 
                    new Dictionary<string, string>()
                );
                if (exitCode != 0)
                {
                    return exitCode;
                }
            }
            return 0;
        }
        
        static int HandleErrorsAndReturnExitCode(IEnumerable<Error> errors)
        {
            Console.WriteLine($"ERRORS: {string.Join(", ", errors)}");
            return 1;
        }
    }
}
