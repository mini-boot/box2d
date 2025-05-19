using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2ChainDef
    {
        public void* userData;

        [NativeTypeName("const b2Vec2 *")]
        public b2Vec2* points;

        [NativeTypeName("int32_t")]
        public int count;

        public float friction;

        public float restitution;

        public b2Filter filter;

        [MarshalAs(UnmanagedType.I1)]
        public bool isLoop;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
