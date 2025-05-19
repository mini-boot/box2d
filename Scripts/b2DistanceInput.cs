using System.Runtime.InteropServices;

namespace Box2D
{
    public partial struct b2DistanceInput
    {
        public b2DistanceProxy proxyA;

        public b2DistanceProxy proxyB;

        public b2Transform transformA;

        public b2Transform transformB;

        [MarshalAs(UnmanagedType.I1)]
        public bool useRadii;
    }
}
