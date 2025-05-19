using System.Runtime.InteropServices;

namespace Box2D
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool b2TreeQueryCallbackFcn([NativeTypeName("int32_t")] int proxyId, [NativeTypeName("int32_t")] int userData, void* context);
}
