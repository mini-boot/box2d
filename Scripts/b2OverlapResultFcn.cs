using System.Runtime.InteropServices;

namespace Box2D
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool b2OverlapResultFcn(b2ShapeId shapeId, void* context);
}
