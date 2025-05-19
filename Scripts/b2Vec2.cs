using System.Runtime.CompilerServices;

namespace Box2D
{
    public partial struct b2Vec2
    {
        public float x;

        public float y;

        public b2Vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public b2Vec2(UnityEngine.Vector2 vec)
        {
            x = vec.x;
            y = vec.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object other)
        {
            if (other is b2Vec2 other2)
            {
                return Equals(other2);
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(b2Vec2 other)
        {
            return x == other.x && y == other.y;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static b2Vec2 operator-(b2Vec2 a)
        {
            return new b2Vec2
            {
                x = -a.x,
                y = -a.y,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static b2Vec2 operator+(b2Vec2 a, b2Vec2 b)
        {
            return new b2Vec2
            {
                x = a.x + b.x,
                y = a.y + b.y,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static b2Vec2 operator-(b2Vec2 a, b2Vec2 b)
        {
            return new b2Vec2
            {
                x = a.x - b.x,
                y = a.y - b.y,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static b2Vec2 operator*(float a, b2Vec2 b)
        {
            return new b2Vec2
            {
                x = a * b.x,
                y = a * b.y,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]

        public static b2Vec2 operator*(b2Vec2 a, float b)
        {
            return new b2Vec2
            {
                x = a.x * b,
                y = a.y * b,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(b2Vec2 a, b2Vec2 b)
        {
            return a.x == b.x && a.y == b.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(b2Vec2 a, b2Vec2 b)
        {
            return a.x != b.x || a.y != b.y;
        }
    }
}
