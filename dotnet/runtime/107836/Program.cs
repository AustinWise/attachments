using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;

BenchmarkRunner.Run<ProcessLaunchBenchmarks>(args: args);

public class ProcessLaunchBenchmarks
{
    const string ECHOED_OUTPUT = "hello world";

    [Params(1, 16, 256)]
    public int NumberOfProceses;

    [Benchmark]
    public void LaunchStandard()
    {
        Parallel.For(0, NumberOfProceses, i =>
        {
            var psi = new ProcessStartInfo("cmd.exe", "/c exit");

            using Process p = Process.Start(psi)!;
            p.WaitForExit();
        });
    }

    [Benchmark]
    public void LaunchWithRedirection()
    {
        Parallel.For(0, NumberOfProceses, i =>
        {
            var psi = new ProcessStartInfo("cmd.exe", $"/c echo {ECHOED_OUTPUT}");
            psi.RedirectStandardOutput = true;

            using Process p = Process.Start(psi)!;
            _ = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        });
    }
}