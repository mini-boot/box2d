namespace Box2D
{
    public partial struct b2Rot
    {
        public float c;

        public float s;

        public b2Rot(float c, float s)
        {
            this.c = c;
            this.s = s;
        }

        public b2Rot(UnityEngine.Vector2 vec)
        {
            c = vec.x;
            s = vec.y;
        }
    }
}
