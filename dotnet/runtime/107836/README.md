# Removing global lock from Process.Start on Windows

Build dotnet/runtime with:

```batch
build.cmd -s clr+libs -c release
src\tests\build.cmd Release generatelayoutonly
```

## Benchmark results

```txt
BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4169/23H2/2023Update/SunValley3)
AMD Ryzen Threadripper PRO 3955WX 16-Cores, 1 CPU, 32 logical and 16 physical cores
```

### .NET 9 RC 1

```batch
dotnet run -c release
```

```txt
.NET SDK 9.0.100-rc.1.24452.12
  [Host]     : .NET 9.0.0 (9.0.24.43107), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.43107), X64 RyuJIT AVX2
```

| Method                | NumberOfProceses | Mean       | Error     | StdDev    |
|---------------------- |----------------- |-----------:|----------:|----------:|
| **LaunchStandard**        | **1**                |   **5.474 ms** | **0.0927 ms** | **0.0867 ms** |
| LaunchWithRedirection | 1                |   5.593 ms | 0.1062 ms | 0.1090 ms |
| **LaunchStandard**        | **16**               |  **30.802 ms** | **0.3729 ms** | **0.3488 ms** |
| LaunchWithRedirection | 16               |  31.057 ms | 0.2395 ms | 0.2000 ms |
| **LaunchStandard**        | **256**              | **469.180 ms** | **5.7967 ms** | **5.1387 ms** |
| LaunchWithRedirection | 256              | 474.595 ms | 5.7172 ms | 5.3479 ms |

### PR

https://github.com/dotnet/runtime/pull/107836

```batch
dotnet run -c release -- --coreRun F:\externsrc\dotnet\runtime\artifacts\tests\coreclr\windows.x64.Release\Tests\Core_Root\corerun.exe
```

```txt
.NET SDK 9.0.100-rc.1.24452.12
  [Host]     : .NET 9.0.0 (9.0.24.43107), X64 RyuJIT AVX2
  Job-QVPEDD : .NET 10.0.0 (42.42.42.42424), X64 RyuJIT AVX2
```

| Method                | NumberOfProceses | Mean       | Error     | StdDev     |
|---------------------- |----------------- |-----------:|----------:|-----------:|
| **LaunchStandard**        | **1**                |   **5.766 ms** | **0.0796 ms** |  **0.0745 ms** |
| LaunchWithRedirection | 1                |   5.656 ms | 0.1119 ms |  0.1289 ms |
| **LaunchStandard**        | **16**               |  **14.422 ms** | **0.1775 ms** |  **0.1661 ms** |
| LaunchWithRedirection | 16               |  32.850 ms | 0.6493 ms |  0.6377 ms |
| **LaunchStandard**        | **256**              | **146.740 ms** | **3.5220 ms** | **10.2738 ms** |
| LaunchWithRedirection | 256              | 486.269 ms | 8.6506 ms |  7.2236 ms |
