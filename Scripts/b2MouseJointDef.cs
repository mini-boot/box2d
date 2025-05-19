using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2MouseJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 target;

        public float hertz;

        public float dampingRatio;

        public float maxForce;

        [MarshalAs(UnmanagedType.I1)]
        public bool collideConnected;

        public void* userData;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
