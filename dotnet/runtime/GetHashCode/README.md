# Porting GetHashCode to use QCALL

Not actually currently faster.

## Main

```bash
dotnet run -c release -- --coreRun ~/src/dotnet/runtime.main/artifacts/tests/coreclr/osx.arm64.Release/Tests/Core_Root/corerun
```

```txt
BenchmarkDotNet v0.13.12, macOS Sonoma 14.5 (23F79) [Darwin 23.5.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 9.0.100-preview.6.24328.19
  [Host]     : .NET 9.0.0 (9.0.24.32707), Arm64 RyuJIT AdvSIMD
  Job-EYEMPW : .NET 9.0.0 (42.42.42.42424), Arm64 RyuJIT AdvSIMD

Toolchain=CoreRun  
```

| Method                                    | NumberOfObjects | Mean       | Error     | StdDev    |
|------------------------------------------ |---------------- |-----------:|----------:|----------:|
| TryGetExistingValue                       | 1               |  4.2349 ns | 0.0042 ns | 0.0035 ns |
| TryGetNonExistentValue_EmptyObjectHeader  | 1               |  1.1358 ns | 0.0011 ns | 0.0010 ns |
| TryGetNonExistentValue_HashInHeader       | 1               |  2.7649 ns | 0.0019 ns | 0.0016 ns |
| TryGetNonExistentValue_SyncBlockButNoHash | 1               |  1.1341 ns | 0.0015 ns | 0.0012 ns |
| TryGetNonExistentValue_HashInSyncBlock    | 1               |  2.0526 ns | 0.0021 ns | 0.0019 ns |
| GetHashCode_HashInHeader                  | 1               |  0.7065 ns | 0.0011 ns | 0.0009 ns |
| GetHashCode_HashInSyncBlock               | 1               |  0.7107 ns | 0.0011 ns | 0.0009 ns |
| CreateHashCode                            | 1               | 13.1376 ns | 0.0239 ns | 0.0223 ns |

## PR

```bash
dotnet run -c release -- --coreRun ~/src/dotnet/runtime/artifacts/tests/coreclr/osx.arm64.Release/Tests/Core_Root/corerun
```

```txt
BenchmarkDotNet v0.13.12, macOS Sonoma 14.5 (23F79) [Darwin 23.5.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK 9.0.100-preview.6.24328.19
  [Host]     : .NET 9.0.0 (9.0.24.32707), Arm64 RyuJIT AdvSIMD
  Job-ALCFJQ : .NET 9.0.0 (42.42.42.42424), Arm64 RyuJIT AdvSIMD

Toolchain=CoreRun
```

| Method                                    | NumberOfObjects | Mean       | Error     | StdDev    |
|------------------------------------------ |---------------- |-----------:|----------:|----------:|
| TryGetExistingValue                       | 1               |  4.4560 ns | 0.1060 ns | 0.1178 ns |
| TryGetNonExistentValue_EmptyObjectHeader  | 1               |  1.2557 ns | 0.0011 ns | 0.0009 ns |
| TryGetNonExistentValue_HashInHeader       | 1               |  2.5816 ns | 0.0042 ns | 0.0035 ns |
| TryGetNonExistentValue_SyncBlockButNoHash | 1               |  1.3084 ns | 0.0153 ns | 0.0135 ns |
| TryGetNonExistentValue_HashInSyncBlock    | 1               |  2.3451 ns | 0.0182 ns | 0.0170 ns |
| GetHashCode_HashInHeader                  | 1               |  0.8331 ns | 0.0032 ns | 0.0030 ns |
| GetHashCode_HashInSyncBlock               | 1               |  1.5307 ns | 0.0022 ns | 0.0020 ns |
| CreateHashCode                            | 1               | 10.8109 ns | 0.0156 ns | 0.0139 ns |
