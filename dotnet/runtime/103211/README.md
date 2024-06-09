# Porting RegisterForFinalization to use QCALL

Build CLR with:

```bash
./build.sh -s clr+libs -c release
./src/tests/build.sh Release generatelayoutonly
```

## .NET 8 Result

```txt
BenchmarkDotNet v0.13.12, macOS Sonoma 14.5 (23F79) [Darwin 23.5.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.5 (8.0.524.21615), Arm64 RyuJIT AdvSIMD
```

| Method          | Mean      | Error     | StdDev    |
|---------------- |----------:|----------:|----------:|
| NotFinializable |  1.051 ns | 0.0178 ns | 0.0149 ns |
| Finializable    | 14.278 ns | 0.1741 ns | 0.2497 ns |

## Main

https://github.com/dotnet/runtime/commit/39ecbe0ed850fa6d6d4f0ebe1917bca1e154e82d

```txt
BenchmarkDotNet v0.13.12, macOS Sonoma 14.5 (23F79) [Darwin 23.5.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), Arm64 RyuJIT AdvSIMD
  Job-UXNDHB : .NET 9.0.0 (42.42.42.42424), Arm64 RyuJIT AdvSIMD

Toolchain=CoreRun  
```

| Method          | Mean      | Error     | StdDev    |
|---------------- |----------:|----------:|----------:|
| NotFinializable |  1.315 ns | 0.0019 ns | 0.0017 ns |
| Finializable    | 15.057 ns | 0.1719 ns | 0.2466 ns |

## PR

Run with:

```bash
dotnet run -c release -- --coreRun ~/src/dotnet/runtime/artifacts/tests/coreclr/osx.arm64.Release/Tests/Core_Root/corerun
```

```txt
BenchmarkDotNet v0.13.12, macOS Sonoma 14.5 (23F79) [Darwin 23.5.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), Arm64 RyuJIT AdvSIMD
  Job-UTDEIM : .NET 9.0.0 (42.42.42.42424), Arm64 RyuJIT AdvSIMD

Toolchain=CoreRun  
```

| Method          | Mean       | Error     | StdDev    |
|---------------- |-----------:|----------:|----------:|
| NotFinializable |  0.3360 ns | 0.0024 ns | 0.0021 ns |
| Finializable    | 12.4418 ns | 0.1961 ns | 0.2812 ns |
