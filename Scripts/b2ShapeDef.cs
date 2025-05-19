using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2ShapeDef
    {
        public void* userData;

        public float friction;

        public float restitution;

        public float density;

        public b2Filter filter;

        [MarshalAs(UnmanagedType.I1)]
        public bool isSensor;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableSensorEvents;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableContactEvents;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableHitEvents;

        [MarshalAs(UnmanagedType.I1)]
        public bool enablePreSolveEvents;

        [MarshalAs(UnmanagedType.I1)]
        public bool forceContactCreation;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
