using System;
using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2DebugDraw
    {
        public delegate void DrawPolygonDelegate(b2Vec2* vertices, int vertexCount, b2HexColor color, void* context);
        public delegate void DrawSolidPolygonDelegate(b2Transform transform, b2Vec2* vertices, int vertexCount, float radius, b2HexColor color, void* context);
        public delegate void DrawCircleDelegate(b2Vec2 center, float radius, b2HexColor color, void* context);
        public delegate void DrawSolidCircleDelegate(b2Transform transform, float radius, b2HexColor color, void* context);
        public delegate void DrawCapsuleDelegate(b2Vec2 p1, b2Vec2 p2, float radius, b2HexColor color, void* context);
        public delegate void DrawSolidCapsuleDelegate(b2Vec2 p1, b2Vec2 p2, float radius, b2HexColor color, void* context);
        public delegate void DrawSegmentDelegate(b2Vec2 p1, b2Vec2 p2, b2HexColor color, void* context);
        public delegate void DrawTransformDelegate(b2Transform transform, void* context);
        public delegate void DrawPointDelegate(b2Vec2 p, float size, b2HexColor color, void* context);
        public delegate void DrawStringDelegate(b2Vec2 p, char* s, void* context);

        [NativeTypeName("void (*)(const b2Vec2 *, int, b2HexColor, void *)")]
        public IntPtr DrawPolygon;

        [NativeTypeName("void (*)(b2Transform, const b2Vec2 *, int, float, b2HexColor, void *)")]
        public IntPtr DrawSolidPolygon;

        [NativeTypeName("void (*)(b2Vec2, float, b2HexColor, void *)")]
        public IntPtr DrawCircle;

        [NativeTypeName("void (*)(b2Transform, float, b2HexColor, void *)")]
        public IntPtr DrawSolidCircle;

        [NativeTypeName("void (*)(b2Vec2, b2Vec2, float, b2HexColor, void *)")]
        public IntPtr DrawCapsule;

        [NativeTypeName("void (*)(b2Vec2, b2Vec2, float, b2HexColor, void *)")]
        public IntPtr DrawSolidCapsule;

        [NativeTypeName("void (*)(b2Vec2, b2Vec2, b2HexColor, void *)")]
        public IntPtr DrawSegment;

        [NativeTypeName("void (*)(b2Transform, void *)")]
        public IntPtr DrawTransform;

        [NativeTypeName("void (*)(b2Vec2, float, b2HexColor, void *)")]
        public IntPtr DrawPoint;

        [NativeTypeName("void (*)(b2Vec2, const char *, void *)")]
        public IntPtr DrawString;

        public b2AABB drawingBounds;

        [MarshalAs(UnmanagedType.I1)]
        public bool useDrawingBounds;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawShapes;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawJoints;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawJointExtras;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawAABBs;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawMass;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawContacts;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawGraphColors;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawContactNormals;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawContactImpulses;

        [MarshalAs(UnmanagedType.I1)]
        public bool drawFrictionImpulses;

        public void* context;
    }
}
