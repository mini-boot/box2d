using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2DistanceJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 localAnchorA;

        public b2Vec2 localAnchorB;

        public float length;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableSpring;

        public float hertz;

        public float dampingRatio;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableLimit;

        public float minLength;

        public float maxLength;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableMotor;

        public float maxMotorForce;

        public float motorSpeed;

        [MarshalAs(UnmanagedType.I1)]
        public bool collideConnected;

        public void* userData;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
