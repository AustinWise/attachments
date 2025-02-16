# Removing global lock from Process.Start on Windows

Build dotnet/runtime with:

```batch
build.cmd -s clr+libs -c release
src\tests\build.cmd Release generatelayoutonly
```

## Benchmark results

```batch
dotnet run -c release ProcessLaunch.csproj
```

```txt
BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4890/23H2/2023Update/SunValley3)
AMD Ryzen Threadripper PRO 3955WX 16-Cores, 1 CPU, 32 logical and 16 physical cores
.NET SDK 10.0.100-alpha.1.25077.2
  [Host]     : .NET 10.0.0 (10.0.25.7313), X64 RyuJIT AVX2
  Job-LROBIW : .NET 10.0.0 (42.42.42.42424), X64 RyuJIT AVX2
  Job-SMCMBC : .NET 10.0.0 (42.42.42.42424), X64 RyuJIT AVX2
```

| Method                                | NumberOfProceses | Toolchain |         Mean |       Error |      StdDev |    Ratio | RatioSD |
| ------------------------------------- | ---------------- | --------- | -----------: | ----------: | ----------: | -------: | ------: |
| LaunchStandard                        | 1                | main      |    10.446 ms |   0.4293 ms |   1.2454 ms |     1.02 |    0.22 |
| LaunchStandard                        | 1                | **PR**    |     6.167 ms |   0.1224 ms |   0.2609 ms | **0.60** |    0.11 |
| LaunchStandard                        | 16               | main      |   169.434 ms |  11.9417 ms |  35.2104 ms |     1.07 |    0.43 |
| LaunchStandard                        | 16               | **PR**    |    44.504 ms |   2.2844 ms |   6.6998 ms | **0.28** |    0.10 |
| LaunchStandard                        | 256              | **main**  | 1,632.245 ms |  84.9272 ms | 250.4099 ms | **1.02** |    0.23 |
| LaunchStandard                        | 256              | PR        | 2,066.674 ms |  41.1199 ms |  43.9978 ms |     1.30 |    0.21 |
| LaunchStandardNoInheritHandles        | 1                | main      |    11.593 ms |   0.2867 ms |   0.8316 ms |     1.01 |    0.11 |
| LaunchStandardNoInheritHandles        | 1                | **PR**    |     7.271 ms |   0.2678 ms |   0.7897 ms | **0.63** |    0.08 |
| LaunchStandardNoInheritHandles        | 16               | main      |   190.073 ms |   6.2624 ms |  18.1684 ms |     1.01 |    0.14 |
| LaunchStandardNoInheritHandles        | 16               | **PR**    |    68.692 ms |   2.8246 ms |   8.2396 ms | **0.36** |    0.06 |
| LaunchStandardNoInheritHandles        | 256              | main      | 2,986.470 ms | 127.7818 ms | 376.7677 ms |     1.02 |    0.18 |
| LaunchStandardNoInheritHandles        | 256              | **PR**    | 2,328.144 ms |  45.9449 ms |  93.8532 ms | **0.79** |    0.11 |
| LaunchWithRedirection                 | 1                | main      |    11.590 ms |   1.1185 ms |   3.2980 ms |     1.09 |    0.45 |
| LaunchWithRedirection                 | 1                | **PR**    |    10.585 ms |   0.2310 ms |   0.6774 ms | **0.99** |    0.29 |
| LaunchWithRedirection                 | 16               | main      |   185.195 ms |   6.0185 ms |  17.6512 ms |     1.01 |    0.13 |
| LaunchWithRedirection                 | 16               | **PR**    |   138.077 ms |   4.0164 ms |  11.7795 ms | **0.75** |    0.09 |
| LaunchWithRedirection                 | 256              | main      | 3,684.266 ms | 104.3015 ms | 307.5355 ms |     1.01 |    0.12 |
| LaunchWithRedirection                 | 256              | **PR**    | 1,236.441 ms |  62.7948 ms | 185.1519 ms | **0.34** |    0.06 |
| LaunchWithRedirectionNoInheritHandles | 1                | **main**  |     7.972 ms |   0.2437 ms |   0.6711 ms | **1.01** |    0.12 |
| LaunchWithRedirectionNoInheritHandles | 1                | PR        |    11.204 ms |   0.3299 ms |   0.9728 ms |     1.42 |    0.17 |
| LaunchWithRedirectionNoInheritHandles | 16               | main      |   197.156 ms |   6.7583 ms |  19.9270 ms |     1.01 |    0.15 |
| LaunchWithRedirectionNoInheritHandles | 16               | **PR**    |   110.851 ms |   4.0471 ms |  11.9328 ms | **0.57** |    0.08 |
| LaunchWithRedirectionNoInheritHandles | 256              | main      | 4,079.342 ms | 229.9083 ms | 674.2812 ms |     1.04 |    0.31 |
| LaunchWithRedirectionNoInheritHandles | 256              | **PR**    |   705.276 ms |  32.8267 ms |  96.7903 ms | **0.18** |    0.05 |
