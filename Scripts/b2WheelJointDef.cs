using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2WheelJointDef
    {
        public b2BodyId bodyIdA;

        public b2BodyId bodyIdB;

        public b2Vec2 localAnchorA;

        public b2Vec2 localAnchorB;

        public b2Vec2 localAxisA;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableSpring;

        public float hertz;

        public float dampingRatio;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableLimit;

        public float lowerTranslation;

        public float upperTranslation;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableMotor;

        public float maxMotorTorque;

        public float motorSpeed;

        [MarshalAs(UnmanagedType.I1)]
        public bool collideConnected;

        public void* userData;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
