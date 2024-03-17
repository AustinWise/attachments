// Based on https://gist.github.com/lambdageek/c53949741489cac862d7918f2132b5a9

using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class P {

    private object flatLockObjectNoHash = new ();
    private object flatPreHashObjectNoLock;
    private object inflatedLockObject;
   
    public P () {
        flatPreHashObjectNoLock = new object();
        flatPreHashObjectNoLock.GetHashCode(); // preinitialize

        inflatedLockObject = new object();
        inflatedLockObject.GetHashCode();
        lock (inflatedLockObject) {};
    }

    [Benchmark]
    public void LockPulseUnlockFlatObjNoHash() {
        lock (flatLockObjectNoHash) { Monitor.Pulse(flatLockObjectNoHash); }
    }

    [Benchmark]
    public void LockUnlockFlatObjNoHash() {
        lock (flatLockObjectNoHash)  {}
    }

    [Benchmark]
    public void GetHashCodeNoLock() {
        flatPreHashObjectNoLock.GetHashCode();
    }

    [Benchmark]
    public void LockUnlockInflatedObject() {
        lock (inflatedLockObject) { }
    }

    [Benchmark]
    public void GetHashCodeInflatedObject()
    {
        RuntimeHelpers.GetHashCode(inflatedLockObject);
    }

    private readonly ConditionalWeakTable<object, object> mWeakTable = new ()
    {
        {new object(), new object()},
    };

    [Benchmark]
    public bool TryGetNonExistentValue()
    {
        return mWeakTable.TryGetValue(inflatedLockObject, out object? _);
    }
    

    public static void Main(string[] args)
        => BenchmarkSwitcher.FromAssembly(typeof(P).Assembly).Run(args);
}
