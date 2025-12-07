```

BenchmarkDotNet v0.15.8, Linux Ubuntu 25.10 (Questing Quokka)
AMD Ryzen Threadripper PRO 3955WX 16-Cores 1.75GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]   : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  ShortRun : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                | Mean       | Error       | StdDev    | Ratio | RatioSD | Code Size |
|---------------------- |-----------:|------------:|----------:|------:|--------:|----------:|
| GetCallbacksHardCoded | 60.9581 ns | 126.7570 ns | 6.9480 ns | 1.008 |    0.14 |   3,699 B |
| GetCallbacksVar       |  0.0000 ns |   0.0000 ns | 0.0000 ns | 0.000 |    0.00 |      11 B |
