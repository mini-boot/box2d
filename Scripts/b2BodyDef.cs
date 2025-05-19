using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2BodyDef
    {
        public b2BodyType type;

        public b2Vec2 position;

        public b2Rot rotation;

        public b2Vec2 linearVelocity;

        public float angularVelocity;

        public float linearDamping;

        public float angularDamping;

        public float gravityScale;

        public float sleepThreshold;

        public void* userData;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableSleep;

        [MarshalAs(UnmanagedType.I1)]
        public bool isAwake;

        [MarshalAs(UnmanagedType.I1)]
        public bool fixedRotation;

        [MarshalAs(UnmanagedType.I1)]
        public bool isBullet;

        [MarshalAs(UnmanagedType.I1)]
        public bool isEnabled;

        [MarshalAs(UnmanagedType.I1)]
        public bool automaticMass;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
