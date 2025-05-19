using System.Runtime.InteropServices;

namespace Box2D
{
    public partial struct b2CastOutput
    {
        public b2Vec2 normal;

        public b2Vec2 point;

        public float fraction;

        [NativeTypeName("int32_t")]
        public int iterations;

        [MarshalAs(UnmanagedType.I1)]
        public bool hit;
    }
}
