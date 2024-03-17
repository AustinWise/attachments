This program works fine on CoreCLR.

This program crashes on NativeAOT with:

```
Unhandled Exception: System.InvalidCastException: Specified cast is not valid.
   at System.Runtime.TypeCast.ThrowInvalidCastException(MethodTable*) + 0x14
   at System.Runtime.TypeCast.ChekCastAny_NoCacheLookup(MethodTable*, Object) + 0xd8
   at System.Runtime.TypeCast.CheckCastAny(MethodTable*, Object) + 0xd0
   at System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer[TDelegate](IntPtr) + 0xa4
   at MyFreachableObject.Finalize() + 0x20
   at System.Runtime.__Finalizer.DrainQueue() + 0x38
   at System.Runtime.__Finalizer.ProcessFinalizers() + 0x44
```
