using Box2DConstants = Box2D.Constants;

namespace Box2D
{
    public partial struct b2Circle
    {
        public b2Vec2 center;

        public float radius;

        public b2Circle(float radius)
        {
            center = Box2DConstants.b2Vec2_zero;
            this.radius = radius;
        }

        public b2Circle(b2Vec2 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public b2Circle(UnityEngine.Vector2 center, float radius)
        {
            this.center = new b2Vec2(center);
            this.radius = radius;
        }
    }
}
