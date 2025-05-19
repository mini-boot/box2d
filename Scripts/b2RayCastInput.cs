namespace Box2D
{
    public partial struct b2RayCastInput
    {
        public b2Vec2 origin;

        public b2Vec2 translation;

        public float maxFraction;

        public b2RayCastInput(b2Vec2 origin, b2Vec2 translation, float maxFraction)
        {
            this.origin = origin;
            this.translation = translation;
            this.maxFraction = maxFraction;
        }
    }
}
