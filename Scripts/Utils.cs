namespace Box2D
{
    public static class Utils
    {
        public static float b2MinFloat(float a, float b)
        {
            return a < b ? a : b;
        }

        public static float b2MaxFloat(float a, float b)
        {
            return a > b ? a : b;
        }

        public static float b2AbsFloat(float a)
        {
            return a < 0 ? -a : a;
        }

        public static float b2ClampFloat(float a, float lower, float upper)
        {
            return a < lower ? lower : (a > upper ? upper : a);
        }

        public static int b2MinInt(int a, int b)
        {
            return a < b ? a : b;
        }

        public static int b2MaxInt(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int b2AbsInt(int a)
        {
            return a < 0 ? -a : a;
        }

        public static int b2ClampInt(int a, int lower, int upper)
        {
            return a < lower ? lower : (a > upper ? upper : a);
        }

        public static float b2Dot(b2Vec2 a, b2Vec2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public static float b2Cross(b2Vec2 a, b2Vec2 b)
        {
            return a.x * b.y - a.y * b.x;
        }

        public static b2Vec2 b2CrossVS(b2Vec2 v, float s)
        {
            return new b2Vec2
            {
                x = s * v.y,
                y = -s * v.x,
            };
        }

        public static b2Vec2 b2CrossSV(float s, b2Vec2 v)
        {
            return new b2Vec2
            {
                x = -s * v.y,
                y = s * v.x,
            };
        }

        public static b2Vec2 b2LeftPerp(b2Vec2 v)
        {
            return new b2Vec2
            {
                x = -v.y,
                y = v.x,
            };
        }

        public static b2Vec2 b2RightPerp(b2Vec2 v)
        {
            return new b2Vec2
            {
                x = v.y,
                y = -v.x,
            };
        }

        public static b2Vec2 b2Add(b2Vec2 a, b2Vec2 b)
        {
            return new b2Vec2
            {
                x = a.x + b.x,
                y = a.y + b.y,
            };
        }

        public static b2Vec2 b2Sub(b2Vec2 a, b2Vec2 b)
        {
            return new b2Vec2
            {
                x = a.x - b.x,
                y = a.y - b.y,
            };
        }

        public static b2Vec2 b2Neg(b2Vec2 a)
        {
            return new b2Vec2
            {
                x = -a.x,
                y = -a.y,
            };
        }

        public static b2Vec2 b2Lerp(b2Vec2 a, b2Vec2 b, float t)
        {
            return new b2Vec2
            {
                x = (1.0f - t) * a.x + t * b.x,
                y = (1.0f - t) * a.y + t * b.y,
            };
        }

        public static b2Vec2 b2Mul(b2Vec2 a, b2Vec2 b)
        {
            return new b2Vec2
            {
                x = a.x * b.x,
                y = a.y * b.y,
            };
        }

        public static b2Vec2 b2MulSV(float s, b2Vec2 v)
        {
            return new b2Vec2
            {
                x = s * v.x,
                y = s * v.y,
            };
        }

        public static b2Vec2 b2MulAdd(b2Vec2 a, float s, b2Vec2 b)
        {
            return new b2Vec2
            {
                x = a.x + s * b.x,
                y = a.y + s * b.y,
            };
        }

        public static b2Vec2 b2MulSub(b2Vec2 a, float s, b2Vec2 b)
        {
            return new b2Vec2
            {
                x = a.x - s * b.x,
                y = a.y - s * b.y,
            };
        }

        public static b2Vec2 b2Abs(b2Vec2 a)
        {
            b2Vec2 b = new b2Vec2();

            b.x = b2AbsFloat(a.x);
            b.y = b2AbsFloat(a.y);
            return b;
        }

        public static b2Vec2 b2Min(b2Vec2 a, b2Vec2 b)
        {
            b2Vec2 c = new b2Vec2();

            c.x = b2MinFloat(a.x, b.x);
            c.y = b2MinFloat(a.y, b.y);
            return c;
        }

        public static b2Vec2 b2Max(b2Vec2 a, b2Vec2 b)
        {
            b2Vec2 c = new b2Vec2();

            c.x = b2MaxFloat(a.x, b.x);
            c.y = b2MaxFloat(a.y, b.y);
            return c;
        }

        public static b2Vec2 b2Clamp(b2Vec2 v, b2Vec2 a, b2Vec2 b)
        {
            b2Vec2 c = new b2Vec2();

            c.x = b2ClampFloat(v.x, a.x, b.x);
            c.y = b2ClampFloat(v.y, a.y, b.y);
            return c;
        }

        public static float b2Length(b2Vec2 v)
        {
            return UnityEngine.Mathf.Sqrt(v.x * v.x + v.y * v.y);
        }

        public static float b2LengthSquared(b2Vec2 v)
        {
            return v.x * v.x + v.y * v.y;
        }

        public static float b2Distance(b2Vec2 a, b2Vec2 b)
        {
            float dx = b.x - a.x;
            float dy = b.y - a.y;

            return UnityEngine.Mathf.Sqrt(dx * dx + dy * dy);
        }

        public static float b2DistanceSquared(b2Vec2 a, b2Vec2 b)
        {
            b2Vec2 c = new b2Vec2
            {
                x = b.x - a.x,
                y = b.y - a.y,
            };

            return c.x * c.x + c.y * c.y;
        }

        public static b2Rot b2MakeRot(float angle)
        {
            b2Rot q = new b2Rot
            {
                c = UnityEngine.Mathf.Cos(angle),
                s = UnityEngine.Mathf.Sin(angle),
            };

            return q;
        }

        public static b2Rot b2NormalizeRot(b2Rot q)
        {
            float mag = UnityEngine.Mathf.Sqrt(q.s * q.s + q.c * q.c);
            float invMag = mag > 0.0 ? 1.0f / mag : 0.0f;
            b2Rot qn = new b2Rot
            {
                c = q.c * invMag,
                s = q.s * invMag,
            };

            return qn;
        }

        public static bool b2IsNormalized(b2Rot q)
        {
            float qq = q.s * q.s + q.c * q.c;

            return 1.0f - 0.0006f < qq && qq < 1.0f + 0.0006f;
        }

        public static b2Rot b2NLerp(b2Rot q1, b2Rot q2, float t)
        {
            float omt = 1.0f - t;
            b2Rot q = new b2Rot
            {
                c = omt * q1.c + t * q2.c,
                s = omt * q1.s + t * q2.s,
            };

            return b2NormalizeRot(q);
        }

        public static b2Rot b2IntegrateRotation(b2Rot q1, float deltaAngle)
        {
            b2Rot q2 = new b2Rot
            {
                c = q1.c - deltaAngle * q1.s,
                s = q1.s + deltaAngle * q1.c,
            };
            float mag = UnityEngine.Mathf.Sqrt(q2.s * q2.s + q2.c * q2.c);
            float invMag = mag > 0.0 ? 1.0f / mag : 0.0f;
            b2Rot qn = new b2Rot
            {
                c = q2.c * invMag,
                s = q2.s * invMag,
            };

            return qn;
        }

        public static float b2ComputeAngularVelocity(b2Rot q1, b2Rot q2, float inv_h)
        {
            float omega = inv_h * (q2.s * q1.c - q2.c * q1.s);

            return omega;
        }

        public static float b2Rot_GetAngle(b2Rot q)
        {
            return UnityEngine.Mathf.Atan2(q.s, q.c);
        }

        public static b2Vec2 b2Rot_GetXAxis(b2Rot q)
        {
            b2Vec2 v = new b2Vec2
            {
                x = q.c,
                y = q.s,
            };

            return v;
        }

        public static b2Vec2 b2Rot_GetYAxis(b2Rot q)
        {
            b2Vec2 v = new b2Vec2
            {
                x = -q.s,
                y = q.c,
            };

            return v;
        }

        public static b2Rot b2MulRot(b2Rot q, b2Rot r)
        {
            b2Rot qr = new b2Rot();

            qr.s = q.s * r.c + q.c * r.s;
            qr.c = q.c * r.c - q.s * r.s;
            return qr;
        }

        public static b2Rot b2InvMulRot(b2Rot q, b2Rot r)
        {
            b2Rot qr = new b2Rot();

            qr.s = q.c * r.s - q.s * r.c;
            qr.c = q.c * r.c + q.s * r.s;
            return qr;
        }

        public static float b2RelativeAngle(b2Rot b, b2Rot a)
        {
            float s = b.s * a.c - b.c * a.s;
            float c = b.c * a.c + b.s * a.s;

            return UnityEngine.Mathf.Atan2(s, c);
        }

        public static float b2UnwindAngle(float angle)
        {
            if (angle < -3.14159265359f)
            {
                return angle + 2.0f * 3.14159265359f;
            }
            else if (angle > 3.14159265359f)
            {
                return angle - 2.0f * 3.14159265359f;
            }

            return angle;
        }

        public static b2Vec2 b2RotateVector(b2Rot q, b2Vec2 v)
        {
            return new b2Vec2
            {
                x = q.c * v.x - q.s * v.y,
                y = q.s * v.x + q.c * v.y,
            };
        }

        public static b2Vec2 b2InvRotateVector(b2Rot q, b2Vec2 v)
        {
            return new b2Vec2
            {
                x = q.c * v.x + q.s * v.y,
                y = -q.s * v.x + q.c * v.y,
            };
        }

        public static b2Vec2 b2TransformPoint(b2Transform t, [NativeTypeName("const b2Vec2")] b2Vec2 p)
        {
            float x = (t.q.c * p.x - t.q.s * p.y) + t.p.x;
            float y = (t.q.s * p.x + t.q.c * p.y) + t.p.y;

            return new b2Vec2
            {
                x = x,
                y = y,
            };
        }

        public static b2Vec2 b2InvTransformPoint(b2Transform t, [NativeTypeName("const b2Vec2")] b2Vec2 p)
        {
            float vx = p.x - t.p.x;
            float vy = p.y - t.p.y;

            return new b2Vec2
            {
                x = t.q.c * vx + t.q.s * vy,
                y = -t.q.s * vx + t.q.c * vy,
            };
        }

        public static b2Transform b2MulTransforms(b2Transform A, b2Transform B)
        {
            b2Transform C = new b2Transform();

            C.q = b2MulRot(A.q, B.q);
            C.p = b2Add(b2RotateVector(A.q, B.p), A.p);
            return C;
        }

        public static b2Transform b2InvMulTransforms(b2Transform A, b2Transform B)
        {
            b2Transform C = new b2Transform();

            C.q = b2InvMulRot(A.q, B.q);
            C.p = b2InvRotateVector(A.q, b2Sub(B.p, A.p));
            return C;
        }

        public static b2Vec2 b2MulMV(b2Mat22 A, b2Vec2 v)
        {
            b2Vec2 u = new b2Vec2
            {
                x = A.cx.x * v.x + A.cy.x * v.y,
                y = A.cx.y * v.x + A.cy.y * v.y,
            };

            return u;
        }

        public static b2Mat22 b2GetInverse22(b2Mat22 A)
        {
            float a = A.cx.x, b = A.cy.x, c = A.cx.y, d = A.cy.y;
            float det = a * d - b * c;

            if (det != 0.0f)
            {
                det = 1.0f / det;
            }

            b2Mat22 B = new b2Mat22
            {
                cx = new b2Vec2
                {
                    x = det * d,
                    y = -det * c,
                },
                cy = new b2Vec2
                {
                    x = -det * b,
                    y = det * a,
                },
            };

            return B;
        }

        public static b2Vec2 b2Solve22(b2Mat22 A, b2Vec2 b)
        {
            float a11 = A.cx.x, a12 = A.cy.x, a21 = A.cx.y, a22 = A.cy.y;
            float det = a11 * a22 - a12 * a21;

            if (det != 0.0f)
            {
                det = 1.0f / det;
            }

            b2Vec2 x = new b2Vec2
            {
                x = det * (a22 * b.x - a12 * b.y),
                y = det * (a11 * b.y - a21 * b.x),
            };

            return x;
        }

        public static bool b2AABB_Contains(b2AABB a, b2AABB b)
        {
            bool s = true;

            s = s && a.lowerBound.x <= b.lowerBound.x;
            s = s && a.lowerBound.y <= b.lowerBound.y;
            s = s && b.upperBound.x <= a.upperBound.x;
            s = s && b.upperBound.y <= a.upperBound.y;
            return s;
        }

        public static b2Vec2 b2AABB_Center(b2AABB a)
        {
            b2Vec2 b = new b2Vec2
            {
                x = 0.5f * (a.lowerBound.x + a.upperBound.x),
                y = 0.5f * (a.lowerBound.y + a.upperBound.y),
            };

            return b;
        }

        public static b2Vec2 b2AABB_Extents(b2AABB a)
        {
            b2Vec2 b = new b2Vec2
            {
                x = 0.5f * (a.upperBound.x - a.lowerBound.x),
                y = 0.5f * (a.upperBound.y - a.lowerBound.y),
            };

            return b;
        }

        public static b2AABB b2AABB_Union(b2AABB a, b2AABB b)
        {
            b2AABB c = new b2AABB();

            c.lowerBound.x = b2MinFloat(a.lowerBound.x, b.lowerBound.x);
            c.lowerBound.y = b2MinFloat(a.lowerBound.y, b.lowerBound.y);
            c.upperBound.x = b2MaxFloat(a.upperBound.x, b.upperBound.x);
            c.upperBound.y = b2MaxFloat(a.upperBound.y, b.upperBound.y);
            return c;
        }

        public static bool b2IsNull(b2WorldId id)
        {
            return id.index1 == 0;
        }

        public static bool b2IsNull(b2BodyId id)
        {
            return id.index1 == 0;
        }

        public static bool b2IsNull(b2ShapeId id)
        {
            return id.index1 == 0;
        }

        public static bool b2IsNull(b2JointId id)
        {
            return id.index1 == 0;
        }

        public static bool b2IsNull(b2ChainId id)
        {
            return id.index1 == 0;
        }

        public static bool b2IsNonNull(b2WorldId id)
        {
            return id.index1 != 0;
        }

        public static bool b2IsNonNull(b2BodyId id)
        {
            return id.index1 != 0;
        }

        public static bool b2IsNonNull(b2ShapeId id)
        {
            return id.index1 != 0;
        }

        public static bool b2IsNonNull(b2JointId id)
        {
            return id.index1 != 0;
        }

        public static bool b2IsNonNull(b2ChainId id)
        {
            return id.index1 != 0;
        }

        public static bool b2IdEquals(b2BodyId id1, b2BodyId id2)
        {
            return id1.index1 == id2.index1 && id1.world0 == id2.world0 && id1.revision == id2.revision;
        }

        public static bool b2IdEquals(b2ShapeId id1, b2ShapeId id2)
        {
            return id1.index1 == id2.index1 && id1.world0 == id2.world0 && id1.revision == id2.revision;
        }

        public static bool b2IdEquals(b2JointId id1, b2JointId id2)
        {
            return id1.index1 == id2.index1 && id1.world0 == id2.world0 && id1.revision == id2.revision;
        }

        public static bool b2IdEquals(b2ChainId id1, b2ChainId id2)
        {
            return id1.index1 == id2.index1 && id1.world0 == id2.world0 && id1.revision == id2.revision;
        }

        public static UnityEngine.Vector2 ConvertToUnityVector2(this b2Vec2 vec)
        {
            return new UnityEngine.Vector2(vec.x, vec.y);
        }

        public static UnityEngine.Vector2 ConvertToUnityVector2(this b2Rot rot)
        {
            return new UnityEngine.Vector2(rot.c, rot.s);
        }

        public static UnityEngine.Color ConvertToUnityColor(this b2HexColor hexColor)
        {
            int value = (int)hexColor;

            byte r = (byte)((value >> 16) & 0xFF);
            byte g = (byte)((value >> 8) & 0xFF);
            byte b = (byte)((value) & 0xFF);

            return new UnityEngine.Color(r / 255.0f, g / 255.0f, b / 255.0f);
        }

        public static UnityEngine.Rect ConvertToRect(this b2AABB aabb)
        {
            return new UnityEngine.Rect(aabb.lowerBound.x, aabb.lowerBound.y, aabb.upperBound.x - aabb.lowerBound.x, aabb.upperBound.y - aabb.lowerBound.y);
        }
    }
}