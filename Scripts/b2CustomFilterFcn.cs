using System.Runtime.InteropServices;

namespace Box2D
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool b2CustomFilterFcn(b2ShapeId shapeIdA, b2ShapeId shapeIdB, void* context);
}
