using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2RevoluteJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 localAnchorA;

        public b2Vec2 localAnchorB;

        public float referenceAngle;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableSpring;

        public float hertz;

        public float dampingRatio;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableLimit;

        public float lowerAngle;

        public float upperAngle;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableMotor;

        public float maxMotorTorque;

        public float motorSpeed;

        public float drawSize;

        [MarshalAs(UnmanagedType.I1)]
        public bool collideConnected;

        public void* userData;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
