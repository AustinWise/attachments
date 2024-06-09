using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Perf_ReRegisterForFinalize>(args: args);

public class Perf_ReRegisterForFinalize
{
    private static readonly object notFinializableObject = new();
    private static readonly object finializableObject = new FinializableObject();

    [Benchmark]
    public void NotFinializable() => GC.ReRegisterForFinalize(notFinializableObject);

    [Benchmark]
    public void Finializable() => GC.ReRegisterForFinalize(finializableObject);
}

class FinializableObject
{
    ~FinializableObject() {}
}