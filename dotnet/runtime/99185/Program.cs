using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

unsafe static class Program
{
    static void Main()
    {
        MyFreachableObject.Alloc();

        while (true)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}

class MyFreachableObject
{
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Alloc()
    {
        new MyFreachableObject();
    }

    static void SomeFunction()
    {
    }

    readonly Action _del;
    readonly nint _fnptr;

    MyFreachableObject()
    {
        _del = new Action(SomeFunction);
        _fnptr = Marshal.GetFunctionPointerForDelegate(_del);
    }

    ~MyFreachableObject()
    {
        var del = Marshal.GetDelegateForFunctionPointer<Action>(_fnptr);
        if (!ReferenceEquals(_del, del))
        {
            throw new Exception("delegate mismatch");
        }
        GC.ReRegisterForFinalize(this);
    }
}