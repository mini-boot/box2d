namespace Box2D
{
    public partial struct b2Transform
    {
        public b2Vec2 p;

        public b2Rot q;

        public b2Transform(b2Vec2 p, b2Rot q)
        {
            this.p = p;
            this.q = q;
        }

        public b2Transform(b2Vec2 p)
        {
            this.p = p;
            q = Constants.b2Rot_identity;
        }

        public b2Transform(UnityEngine.Vector2 p)
        {
            this.p = new b2Vec2(p);
            q = Constants.b2Rot_identity;
        }

        public b2Transform(Transform2D transform)
        {
            p = new b2Vec2(transform.p);
            q = new b2Rot(transform.q);
        }
    }
}
