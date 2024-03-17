
This is a reproduction program for https://github.com/dotnet/runtime/pull/81010 .

Run with:

```batch
run.cmd
```

Then attach with Visual Studio and Press Enter. When it breaks on the unhandled exception,
the call stack should look garbled:

![](screenshot.png)

# Versions tested with

* .NET SDK 7.0.102
* .NET 7.0.2
* Windows 11  - 10.0.22621.1105
* Visual Studio 17.4.4
