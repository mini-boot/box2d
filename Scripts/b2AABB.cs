namespace Box2D
{
    public partial struct b2AABB
    {
        public b2Vec2 lowerBound;

        public b2Vec2 upperBound;

        public b2AABB(UnityEngine.Rect rect)
        {
            lowerBound = new b2Vec2(rect.min);
            upperBound = new b2Vec2(rect.max);
        }
    }
}
