using System.Runtime.InteropServices;

namespace Box2D
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool b2PreSolveFcn(b2ShapeId shapeIdA, b2ShapeId shapeIdB, b2Manifold* manifold, void* context);
}
