using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<GetHashCodeBenchmarks>(args: args);

public class GetHashCodeBenchmarks
{
    private readonly List<object> mRootedObjects = new();
    private readonly ConditionalWeakTable<object, object> mWeakTable = new();
    private object mAnObjectInTheTable = null!;
    private object mEmptyObjectHeader = new();
    private object mHashInHeader = new();
    private object mSyncBlockButNoHash = new();
    private object mHashInSyncBlock = new();

    [Params(1)]
    public int NumberOfObjects;

    [GlobalSetup]
    public void Setup()
    {
        for (int i = 0; i < NumberOfObjects; i++)
        {
            var obj = new object();
            mRootedObjects.Add(obj);
            mWeakTable.Add(obj, new object());
            mAnObjectInTheTable = obj;
        }
        RuntimeHelpers.GetHashCode(mHashInHeader);
        
        // See SBLK_MASK_LOCK_RECLEVEL, more then 64 recursion levels can't fit in the header.
        const int RECURSION_COUNT = 128;
        for (int i = 0; i < RECURSION_COUNT; i++)
        {
            Monitor.Enter(mSyncBlockButNoHash);
        }
        for (int i = 0; i < RECURSION_COUNT; i++)
        {
            Monitor.Exit(mSyncBlockButNoHash);
        }

        lock (mHashInSyncBlock)
        {
            RuntimeHelpers.GetHashCode(mHashInSyncBlock);
        }
    }

    [Benchmark]
    public bool TryGetExistingValue()
    {
        return mWeakTable.TryGetValue(mAnObjectInTheTable, out object? _);
    }

    [Benchmark]
    public bool TryGetNonExistentValue_EmptyObjectHeader()
    {
        return mWeakTable.TryGetValue(mEmptyObjectHeader, out object? _);
    }

    [Benchmark]
    public bool TryGetNonExistentValue_HashInHeader()
    {
        return mWeakTable.TryGetValue(mHashInHeader, out object? _);
    }

    [Benchmark]
    public bool TryGetNonExistentValue_SyncBlockButNoHash()
    {
        return mWeakTable.TryGetValue(mSyncBlockButNoHash, out object? _);
    }

    [Benchmark]
    public bool TryGetNonExistentValue_HashInSyncBlock()
    {
        return mWeakTable.TryGetValue(mHashInSyncBlock, out object? _);
    }

    [Benchmark]
    public int GetHashCode_HashInHeader()
    {
        return RuntimeHelpers.GetHashCode(mHashInHeader);
    }

    [Benchmark]
    public int GetHashCode_HashInSyncBlock()
    {
        return RuntimeHelpers.GetHashCode(mHashInSyncBlock);
    }

    [Benchmark]
    public int CreateHashCode()
    {
        return RuntimeHelpers.GetHashCode(new object());
    }
}