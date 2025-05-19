using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2BodyMoveEvent
    {
        public b2Transform transform;

        public b2BodyId bodyId;

        public void* userData;

        [MarshalAs(UnmanagedType.I1)]
        public bool fellAsleep;
    }
}
