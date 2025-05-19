using System.Runtime.InteropServices;

namespace Box2D
{
    public partial struct b2RayResult
    {
        public b2ShapeId shapeId;

        public b2Vec2 point;

        public b2Vec2 normal;

        public float fraction;

        [MarshalAs(UnmanagedType.I1)]
        public bool hit;
    }
}
