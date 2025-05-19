using UnityEngine.UIElements;

namespace Box2D
{
    public partial struct b2Segment
    {
        public b2Vec2 point1;

        public b2Vec2 point2;

        public b2Segment(b2Vec2 point1, b2Vec2 point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
    }
}
