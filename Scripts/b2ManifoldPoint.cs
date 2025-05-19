using System.Runtime.InteropServices;

namespace Box2D
{
    public partial struct b2ManifoldPoint
    {
        public b2Vec2 point;

        public b2Vec2 anchorA;

        public b2Vec2 anchorB;

        public float separation;

        public float normalImpulse;

        public float tangentImpulse;

        public float maxNormalImpulse;

        public float normalVelocity;

        [NativeTypeName("uint16_t")]
        public ushort id;

        [MarshalAs(UnmanagedType.I1)]
        public bool persisted;
    }
}
