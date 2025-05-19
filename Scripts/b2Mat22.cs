namespace Box2D
{
    public partial struct b2Mat22
    {
        public b2Vec2 cx;

        public b2Vec2 cy;

        public b2Mat22(b2Vec2 cx, b2Vec2 cy)
        {
            this.cx = cx;
            this.cy = cy;
        }
    }
}
