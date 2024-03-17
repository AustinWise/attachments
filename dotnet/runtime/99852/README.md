

Build dotnet/runtime with:

```
build.cmd -s clr+libs -c release
src\tests\build.cmd Release generatelayoutonly
```

Then run Benchmark with:

```
dotnet run -c release -- --coreRun F:\externsrc\dotnet\runtime\artifacts\tests\coreclr\windows.x64.Release\Tests\Core_Root\corerun.exe
dotnet run -c release -- --coreRun F:\externsrc\dotnet\runtime.main\artifacts\tests\coreclr\windows.x64.Release\Tests\Core_Root\corerun.exe
```


## PR

| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| GetCurrentMethod | 639.9 ns | 3.62 ns | 3.38 ns |

## Merge Base

| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| GetCurrentMethod | 571.2 ns | 2.98 ns | 2.79 ns |

## .NET 9 Preview 2

| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| GetCurrentMethod | 698.8 ns | 2.27 ns | 2.12 ns |
