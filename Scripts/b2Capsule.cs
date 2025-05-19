namespace Box2D
{
    public partial struct b2Capsule
    {
        public b2Vec2 center1;

        public b2Vec2 center2;

        public float radius;

        public b2Capsule(b2Vec2 center1, b2Vec2 center2, float radius)
        {
            this.center1 = center1;
            this.center2 = center2;
            this.radius = radius;
        }

        public b2Capsule(UnityEngine.Vector2 center1, UnityEngine.Vector2 center2, float radius)
        {
            this.center1 = new b2Vec2(center1);
            this.center2 = new b2Vec2(center2);
            this.radius = radius;
        }
    }
}
