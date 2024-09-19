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
| LaunchStandard        | 1                |   6.057 ms | 0.0874 ms |  0.0818 ms |
| LaunchWithRedirection | 1                |   6.088 ms | 0.0956 ms |  0.0894 ms |
| LaunchStandard        | 16               |  14.736 ms | 0.1387 ms |  0.1298 ms |
| LaunchWithRedirection | 16               |  37.486 ms | 0.3947 ms |  0.3499 ms |
| LaunchStandard        | 256              | 136.704 ms | 2.6484 ms |  2.6010 ms |
| LaunchWithRedirection | 256              | 513.196 ms | 9.7459 ms | 10.8325 ms |
