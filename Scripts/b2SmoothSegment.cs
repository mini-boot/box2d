namespace Box2D
{
    public partial struct b2SmoothSegment
    {
        public b2Vec2 ghost1;

        public b2Segment segment;

        public b2Vec2 ghost2;

        [NativeTypeName("int32_t")]
        public int chainId;

        public b2SmoothSegment(b2Vec2 ghost1, b2Segment segment, b2Vec2 ghost2, int chainId = -1)
        {
            this.ghost1 = ghost1;
            this.segment = segment;
            this.ghost2 = ghost2;
            this.chainId = chainId;
        }
    }
}
