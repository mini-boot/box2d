using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2MotorJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 linearOffset;

        public float angularOffset;

        public float maxForce;

        public float maxTorque;

        public float correctionFactor;

        [MarshalAs(UnmanagedType.I1)]
        public bool collideConnected;

        public void* userData;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
