

Build dotnet/runtime with:

```
build.cmd -s clr+libs -c release
src\tests\build.cmd Release generatelayoutonly
```

# Benchmark results

```
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
AMD Ryzen Threadripper PRO 3955WX 16-Cores, 1 CPU, 32 logical and 16 physical cores
```

## PR

https://github.com/dotnet/runtime/pull/99852

```
dotnet run -c release -- --coreRun F:\externsrc\dotnet\runtime\artifacts\tests\coreclr\windows.x64.Release\Tests\Core_Root\corerun.exe
```

| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| GetCurrentMethod | 480.5 ns | 6.14 ns | 5.13 ns |

## Merge Base

https://github.com/dotnet/runtime/commit/52eb3ed834d9bd43d178faef2ff84a4dfd84c555

```
dotnet run -c release -- --coreRun F:\externsrc\dotnet\runtime.main\artifacts\tests\coreclr\windows.x64.Release\Tests\Core_Root\corerun.exe
```

| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| GetCurrentMethod | 571.2 ns | 2.98 ns | 2.79 ns |

## .NET 9 Preview 2

| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| GetCurrentMethod | 698.8 ns | 2.27 ns | 2.12 ns |
