
using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<Program>(config: null, args);
    }

    [Benchmark]
    public MethodBase? GetCurrentMethod() => MethodBase.GetCurrentMethod();
}
