using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

public class ShellUtils
{

    public static int ExecuteShellCommand(String workingDirectory, String command, String args,
        Dictionary<String, String> environmentVariables)
    {
        ProcessStartInfo startInfo = new()
        {
            WorkingDirectory = workingDirectory,
            FileName = command,
            Arguments = args,
            CreateNoWindow = true,
            RedirectStandardOutput = false,
            RedirectStandardError = false,
        };
        foreach (var envVar in environmentVariables)
        {
            startInfo.EnvironmentVariables.Add(envVar.Key, envVar.Value);
        }
        
        var proc = Process.Start(startInfo);
        ArgumentNullException.ThrowIfNull(proc);
        // string output = proc.StandardOutput.ReadToEnd();
        proc.WaitForExit();
        // return output;
        return proc.ExitCode;
    }
}