using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Jobs;
using System.Diagnostics;
using BenchmarkDotNet.Toolchains.CoreRun;
using BenchmarkDotNet.Configs;
using System.Runtime.Versioning;

if (!OperatingSystem.IsWindows())
{
    Console.WriteLine("Only supported on Windows");
    return 1;
}

var mainJob = CreateCoreRunJob("main", @"F:\externsrc\dotnet\runtime.main\artifacts\tests\coreclr\windows.x64.Release\Tests\Core_Root\corerun.exe");
var prJob = CreateCoreRunJob("PR", @"F:\externsrc\dotnet\runtime\artifacts\tests\coreclr\windows.x64.Release\Tests\Core_Root\corerun.exe");

BenchmarkRunner.Run<ProcessLaunchBenchmarks>(
    DefaultConfig.Instance.
    AddJob(mainJob.AsBaseline())
    .AddJob(prJob))

return 0;

static Job CreateCoreRunJob(string name, string coreRunPath)
{
    return Job.Default.WithToolchain(new CoreRunToolchain(new FileInfo(coreRunPath), createCopy: true, targetFrameworkMoniker: "net10.0", displayName: name));
}

[SupportedOSPlatform("windows")]
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
    public void LaunchStandardNoInheritHandles()
    {
        Parallel.For(0, NumberOfProceses, i =>
        {
            var psi = new ProcessStartInfo("cmd.exe", "/c exit");
            psi.InheritHandles = false;

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

    [Benchmark]
    public void LaunchWithRedirectionNoInheritHandles()
    {
        Parallel.For(0, NumberOfProceses, i =>
        {
            var psi = new ProcessStartInfo("cmd.exe", $"/c echo {ECHOED_OUTPUT}");
            psi.RedirectStandardOutput = true;
            psi.InheritHandles = false;

            using Process p = Process.Start(psi)!;
            _ = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        });
    }
}