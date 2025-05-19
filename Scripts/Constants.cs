namespace Box2D
{
    public static class Constants
    {
        public static readonly b2Vec2 b2Vec2_zero = new b2Vec2
        {
            x = 0.0f,
            y = 0.0f,
        };

        public static readonly b2Rot b2Rot_identity = new b2Rot
        {
            c = 1.0f,
            s = 0.0f,
        };

        public static readonly b2Transform b2Transform_identity = new b2Transform
        {
            p = new b2Vec2
            {
                x = 0.0f,
                y = 0.0f,
            },
            q = new b2Rot
            {
                c = 1.0f,
                s = 0.0f,
            },
        };

        public static readonly b2Mat22 b2Mat22_zero = new b2Mat22
        {
            cx = new b2Vec2
            {
                x = 0.0f,
                y = 0.0f,
            },
            cy = new b2Vec2
            {
                x = 0.0f,
                y = 0.0f,
            },
        };

        public static readonly b2WorldId b2WorldId_null = new b2WorldId
        {
            index1 = 0,
            revision = 0
        };

        public static readonly b2BodyId b2BodyId_null = new b2BodyId
        {
            index1 = 0,
            world0 = 0,
            revision = 0
        };

        public static readonly b2ShapeId b2ShapeId_null = new b2ShapeId
        {
            index1 = 0,
            world0 = 0,
            revision = 0
        };

        public static readonly b2JointId b2NullJointId = new b2JointId
        {
            index1 = 0,
            world0 = 0,
            revision = 0
        };

        public static readonly b2ChainId b2ChainId_null = new b2ChainId
        {
            index1 = 0,
            world0 = 0,
            revision = 0
        };


        public static readonly b2DistanceCache b2DistanceCache_empty = new b2DistanceCache
        {
            count = 0
        };
    }
}