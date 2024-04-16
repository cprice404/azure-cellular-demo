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
            Console.WriteLine("BOOTSTRAP!");
            return 0;
        }
        
        static int RunTearDownAndReturnExitCode(TearDownOptions opts)
        {
            Console.WriteLine("TEARDOWN!");
            return 0;
        }
        
        static int HandleErrorsAndReturnExitCode(IEnumerable<Error> errors)
        {
            Console.WriteLine($"ERRORS: {string.Join(", ", errors)}");
            return 1;
        }
    }
}
