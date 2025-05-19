using System;
using System.Runtime.InteropServices;

namespace Box2D
{
    public static unsafe partial class NativeMethods
    {
#if UNITY_IOS
        private const string NativeLibraryName = "__Internal";
#else
        private const string NativeLibraryName = "box2d"; 
#endif

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2SetAllocator([NativeTypeName("b2AllocFcn *")] IntPtr allocFcn, [NativeTypeName("b2FreeFcn *")] IntPtr freeFcn);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2GetByteCount();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2SetAssertFcn([NativeTypeName("b2AssertFcn *")] IntPtr assertFcn);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Version b2GetVersion();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Timer b2CreateTimer();

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long b2GetTicks(b2Timer* timer);
#endif

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2GetMilliseconds([NativeTypeName("const b2Timer *")] b2Timer* timer);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2GetMillisecondsAndReset(b2Timer* timer);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2SleepMilliseconds(int milliseconds);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Yield();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WorldId b2CreateWorld([NativeTypeName("const b2WorldDef *")] b2WorldDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyWorld(b2WorldId worldId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2World_IsValid(b2WorldId id);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_Step(b2WorldId worldId, float timeStep, int subStepCount);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_Draw(b2WorldId worldId, b2DebugDraw* draw);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyEvents b2World_GetBodyEvents(b2WorldId worldId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2SensorEvents b2World_GetSensorEvents(b2WorldId worldId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ContactEvents b2World_GetContactEvents(b2WorldId worldId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_OverlapAABB(b2WorldId worldId, b2AABB aabb, b2QueryFilter filter, [NativeTypeName("b2OverlapResultFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_OverlapCircle(b2WorldId worldId, [NativeTypeName("const b2Circle *")] b2Circle* circle, b2Transform transform, b2QueryFilter filter, [NativeTypeName("b2OverlapResultFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_OverlapCapsule(b2WorldId worldId, [NativeTypeName("const b2Capsule *")] b2Capsule* capsule, b2Transform transform, b2QueryFilter filter, [NativeTypeName("b2OverlapResultFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_OverlapPolygon(b2WorldId worldId, [NativeTypeName("const b2Polygon *")] b2Polygon* polygon, b2Transform transform, b2QueryFilter filter, [NativeTypeName("b2OverlapResultFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_CastRay(b2WorldId worldId, b2Vec2 origin, b2Vec2 translation, b2QueryFilter filter, [NativeTypeName("b2CastResultFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2RayResult b2World_CastRayClosest(b2WorldId worldId, b2Vec2 origin, b2Vec2 translation, b2QueryFilter filter);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_CastCircle(b2WorldId worldId, [NativeTypeName("const b2Circle *")] b2Circle* circle, b2Transform originTransform, b2Vec2 translation, b2QueryFilter filter, [NativeTypeName("b2CastResultFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_CastCapsule(b2WorldId worldId, [NativeTypeName("const b2Capsule *")] b2Capsule* capsule, b2Transform originTransform, b2Vec2 translation, b2QueryFilter filter, [NativeTypeName("b2CastResultFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_CastPolygon(b2WorldId worldId, [NativeTypeName("const b2Polygon *")] b2Polygon* polygon, b2Transform originTransform, b2Vec2 translation, b2QueryFilter filter, [NativeTypeName("b2CastResultFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_EnableSleeping(b2WorldId worldId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_EnableContinuous(b2WorldId worldId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetRestitutionThreshold(b2WorldId worldId, float value);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetHitEventThreshold(b2WorldId worldId, float value);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetCustomFilterCallback(b2WorldId worldId, [NativeTypeName("b2CustomFilterFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetPreSolveCallback(b2WorldId worldId, [NativeTypeName("b2PreSolveFcn *")] IntPtr fcn, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetGravity(b2WorldId worldId, b2Vec2 gravity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2World_GetGravity(b2WorldId worldId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_Explode(b2WorldId worldId, b2Vec2 position, float radius, float impulse);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_SetContactTuning(b2WorldId worldId, float hertz, float dampingRatio, float pushVelocity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_EnableWarmStarting(b2WorldId worldId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Profile b2World_GetProfile(b2WorldId worldId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Counters b2World_GetCounters(b2WorldId worldId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2World_DumpMemoryStats(b2WorldId worldId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyId b2CreateBody(b2WorldId worldId, [NativeTypeName("const b2BodyDef *")] b2BodyDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyBody(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Body_IsValid(b2BodyId id);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyType b2Body_GetType(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetType(b2BodyId bodyId, b2BodyType type);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetUserData(b2BodyId bodyId, void* userData);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* b2Body_GetUserData(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetPosition(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Rot b2Body_GetRotation(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Transform b2Body_GetTransform(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetTransform(b2BodyId bodyId, b2Vec2 position, b2Rot rotation);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLocalPoint(b2BodyId bodyId, b2Vec2 worldPoint);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetWorldPoint(b2BodyId bodyId, b2Vec2 localPoint);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLocalVector(b2BodyId bodyId, b2Vec2 worldVector);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetWorldVector(b2BodyId bodyId, b2Vec2 localVector);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLinearVelocity(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetAngularVelocity(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetLinearVelocity(b2BodyId bodyId, b2Vec2 linearVelocity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetAngularVelocity(b2BodyId bodyId, float angularVelocity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyForce(b2BodyId bodyId, b2Vec2 force, b2Vec2 point, [MarshalAs(UnmanagedType.I1)] bool wake);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyForceToCenter(b2BodyId bodyId, b2Vec2 force, [MarshalAs(UnmanagedType.I1)] bool wake);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyTorque(b2BodyId bodyId, float torque, [MarshalAs(UnmanagedType.I1)] bool wake);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyLinearImpulse(b2BodyId bodyId, b2Vec2 impulse, b2Vec2 point, [MarshalAs(UnmanagedType.I1)] bool wake);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyLinearImpulseToCenter(b2BodyId bodyId, b2Vec2 impulse, [MarshalAs(UnmanagedType.I1)] bool wake);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyAngularImpulse(b2BodyId bodyId, float impulse, [MarshalAs(UnmanagedType.I1)] bool wake);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetMass(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetInertiaTensor(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetLocalCenterOfMass(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Body_GetWorldCenterOfMass(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetMassData(b2BodyId bodyId, b2MassData massData);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2Body_GetMassData(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_ApplyMassFromShapes(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetAutomaticMass(b2BodyId bodyId, [MarshalAs(UnmanagedType.I1)] bool automaticMass);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Body_GetAutomaticMass(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetLinearDamping(b2BodyId bodyId, float linearDamping);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetLinearDamping(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetAngularDamping(b2BodyId bodyId, float angularDamping);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetAngularDamping(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetGravityScale(b2BodyId bodyId, float gravityScale);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetGravityScale(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Body_IsAwake(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetAwake(b2BodyId bodyId, [MarshalAs(UnmanagedType.I1)] bool awake);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_EnableSleep(b2BodyId bodyId, [MarshalAs(UnmanagedType.I1)] bool enableSleep);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Body_IsSleepEnabled(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetSleepThreshold(b2BodyId bodyId, float sleepVelocity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Body_GetSleepThreshold(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Body_IsEnabled(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_Disable(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_Enable(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetFixedRotation(b2BodyId bodyId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Body_IsFixedRotation(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_SetBullet(b2BodyId bodyId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Body_IsBullet(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Body_EnableHitEvents(b2BodyId bodyId, [MarshalAs(UnmanagedType.I1)] bool enableHitEvents);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetShapeCount(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetShapes(b2BodyId bodyId, b2ShapeId* shapeArray, int capacity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetJointCount(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetJoints(b2BodyId bodyId, b2JointId* jointArray, int capacity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetContactCapacity(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Body_GetContactData(b2BodyId bodyId, b2ContactData* contactData, int capacity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2Body_ComputeAABB(b2BodyId bodyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeId b2CreateCircleShape(b2BodyId bodyId, [NativeTypeName("const b2ShapeDef *")] b2ShapeDef* def, [NativeTypeName("const b2Circle *")] b2Circle* circle);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeId b2CreateSegmentShape(b2BodyId bodyId, [NativeTypeName("const b2ShapeDef *")] b2ShapeDef* def, [NativeTypeName("const b2Segment *")] b2Segment* segment);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeId b2CreateCapsuleShape(b2BodyId bodyId, [NativeTypeName("const b2ShapeDef *")] b2ShapeDef* def, [NativeTypeName("const b2Capsule *")] b2Capsule* capsule);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeId b2CreatePolygonShape(b2BodyId bodyId, [NativeTypeName("const b2ShapeDef *")] b2ShapeDef* def, [NativeTypeName("const b2Polygon *")] b2Polygon* polygon);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyShape(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Shape_IsValid(b2ShapeId id);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeType b2Shape_GetType(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyId b2Shape_GetBody(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Shape_IsSensor(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetUserData(b2ShapeId shapeId, void* userData);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* b2Shape_GetUserData(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetDensity(b2ShapeId shapeId, float density);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Shape_GetDensity(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetFriction(b2ShapeId shapeId, float friction);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Shape_GetFriction(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetRestitution(b2ShapeId shapeId, float restitution);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Shape_GetRestitution(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Filter b2Shape_GetFilter(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetFilter(b2ShapeId shapeId, b2Filter filter);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_EnableSensorEvents(b2ShapeId shapeId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Shape_AreSensorEventsEnabled(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_EnableContactEvents(b2ShapeId shapeId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Shape_AreContactEventsEnabled(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_EnablePreSolveEvents(b2ShapeId shapeId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Shape_ArePreSolveEventsEnabled(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_EnableHitEvents(b2ShapeId shapeId, [MarshalAs(UnmanagedType.I1)] bool flag);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Shape_AreHitEventsEnabled(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Shape_TestPoint(b2ShapeId shapeId, b2Vec2 point);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2Shape_RayCast(b2ShapeId shapeId, b2Vec2 origin, b2Vec2 translation);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Circle b2Shape_GetCircle(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Segment b2Shape_GetSegment(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2SmoothSegment b2Shape_GetSmoothSegment(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Capsule b2Shape_GetCapsule(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2Shape_GetPolygon(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetCircle(b2ShapeId shapeId, [NativeTypeName("const b2Circle *")] b2Circle* circle);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetCapsule(b2ShapeId shapeId, [NativeTypeName("const b2Capsule *")] b2Capsule* capsule);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetSegment(b2ShapeId shapeId, [NativeTypeName("const b2Segment *")] b2Segment* segment);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Shape_SetPolygon(b2ShapeId shapeId, [NativeTypeName("const b2Polygon *")] b2Polygon* polygon);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ChainId b2Shape_GetParentChain(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Shape_GetContactCapacity(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2Shape_GetContactData(b2ShapeId shapeId, b2ContactData* contactData, int capacity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2Shape_GetAABB(b2ShapeId shapeId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Shape_GetClosestPoint(b2ShapeId shapeId, b2Vec2 target);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ChainId b2CreateChain(b2BodyId bodyId, [NativeTypeName("const b2ChainDef *")] b2ChainDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyChain(b2ChainId chainId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Chain_SetFriction(b2ChainId chainId, float friction);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Chain_SetRestitution(b2ChainId chainId, float restitution);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Chain_IsValid(b2ChainId id);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DestroyJoint(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Joint_IsValid(b2JointId id);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointType b2Joint_GetType(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyId b2Joint_GetBodyA(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyId b2Joint_GetBodyB(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Joint_GetLocalAnchorA(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Joint_GetLocalAnchorB(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetCollideConnected(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool shouldCollide);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Joint_GetCollideConnected(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_SetUserData(b2JointId jointId, void* userData);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* b2Joint_GetUserData(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2Joint_WakeBodies(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Joint_GetConstraintForce(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2Joint_GetConstraintTorque(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateDistanceJoint(b2WorldId worldId, [NativeTypeName("const b2DistanceJointDef *")] b2DistanceJointDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetLength(b2JointId jointId, float length);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetLength(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_EnableSpring(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableSpring);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2DistanceJoint_IsSpringEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetHertz(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetDampingRatio(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_EnableLimit(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableLimit);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2DistanceJoint_IsLimitEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetLengthRange(b2JointId jointId, float minLength, float maxLength);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMinLength(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMaxLength(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetCurrentLength(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_EnableMotor(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableMotor);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2DistanceJoint_IsMotorEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetMotorSpeed(b2JointId jointId, float motorSpeed);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMotorSpeed(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DistanceJoint_SetMaxMotorForce(b2JointId jointId, float force);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMaxMotorForce(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DistanceJoint_GetMotorForce(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateMotorJoint(b2WorldId worldId, [NativeTypeName("const b2MotorJointDef *")] b2MotorJointDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetLinearOffset(b2JointId jointId, b2Vec2 linearOffset);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2MotorJoint_GetLinearOffset(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetAngularOffset(b2JointId jointId, float angularOffset);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MotorJoint_GetAngularOffset(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetMaxForce(b2JointId jointId, float maxForce);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MotorJoint_GetMaxForce(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetMaxTorque(b2JointId jointId, float maxTorque);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MotorJoint_GetMaxTorque(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MotorJoint_SetCorrectionFactor(b2JointId jointId, float correctionFactor);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MotorJoint_GetCorrectionFactor(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateMouseJoint(b2WorldId worldId, [NativeTypeName("const b2MouseJointDef *")] b2MouseJointDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MouseJoint_SetTarget(b2JointId jointId, b2Vec2 target);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2MouseJoint_GetTarget(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MouseJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MouseJoint_GetSpringHertz(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MouseJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MouseJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2MouseJoint_SetMaxForce(b2JointId jointId, float maxForce);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2MouseJoint_GetMaxForce(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreatePrismaticJoint(b2WorldId worldId, [NativeTypeName("const b2PrismaticJointDef *")] b2PrismaticJointDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_EnableSpring(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableSpring);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2PrismaticJoint_IsSpringEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetSpringHertz(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_EnableLimit(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableLimit);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2PrismaticJoint_IsLimitEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetLowerLimit(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetUpperLimit(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetLimits(b2JointId jointId, float lower, float upper);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_EnableMotor(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableMotor);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2PrismaticJoint_IsMotorEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetMotorSpeed(b2JointId jointId, float motorSpeed);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetMotorSpeed(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2PrismaticJoint_SetMaxMotorForce(b2JointId jointId, float force);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetMaxMotorForce(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2PrismaticJoint_GetMotorForce(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateRevoluteJoint(b2WorldId worldId, [NativeTypeName("const b2RevoluteJointDef *")] b2RevoluteJointDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_EnableSpring(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableSpring);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetSpringHertz(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetAngle(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_EnableLimit(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableLimit);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2RevoluteJoint_IsLimitEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetLowerLimit(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetUpperLimit(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetLimits(b2JointId jointId, float lower, float upper);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_EnableMotor(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableMotor);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2RevoluteJoint_IsMotorEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetMotorSpeed(b2JointId jointId, float motorSpeed);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetMotorSpeed(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetMotorTorque(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2RevoluteJoint_SetMaxMotorTorque(b2JointId jointId, float torque);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2RevoluteJoint_GetMaxMotorTorque(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateWeldJoint(b2WorldId worldId, [NativeTypeName("const b2WeldJointDef *")] b2WeldJointDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WeldJoint_SetLinearHertz(b2JointId jointId, float hertz);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WeldJoint_GetLinearHertz(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WeldJoint_SetLinearDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WeldJoint_GetLinearDampingRatio(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WeldJoint_SetAngularHertz(b2JointId jointId, float hertz);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WeldJoint_GetAngularHertz(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WeldJoint_SetAngularDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WeldJoint_GetAngularDampingRatio(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2JointId b2CreateWheelJoint(b2WorldId worldId, [NativeTypeName("const b2WheelJointDef *")] b2WheelJointDef* def);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_EnableSpring(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableSpring);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2WheelJoint_IsSpringEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetSpringHertz(b2JointId jointId, float hertz);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetSpringHertz(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetSpringDampingRatio(b2JointId jointId, float dampingRatio);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetSpringDampingRatio(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_EnableLimit(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableLimit);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2WheelJoint_IsLimitEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetLowerLimit(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetUpperLimit(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetLimits(b2JointId jointId, float lower, float upper);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_EnableMotor(b2JointId jointId, [MarshalAs(UnmanagedType.I1)] bool enableMotor);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2WheelJoint_IsMotorEnabled(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetMotorSpeed(b2JointId jointId, float motorSpeed);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetMotorSpeed(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2WheelJoint_SetMaxMotorTorque(b2JointId jointId, float torque);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetMaxMotorTorque(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2WheelJoint_GetMotorTorque(b2JointId jointId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2IsValidRay([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakePolygon([NativeTypeName("const b2Hull *")] b2Hull* hull, float radius);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeOffsetPolygon([NativeTypeName("const b2Hull *")] b2Hull* hull, float radius, b2Transform transform);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeSquare(float h);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeBox(float hx, float hy);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeRoundedBox(float hx, float hy, float radius);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2MakeOffsetBox(float hx, float hy, b2Vec2 center, float angle);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Polygon b2TransformPolygon(b2Transform transform, [NativeTypeName("const b2Polygon *")] b2Polygon* polygon);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2ComputeCircleMass([NativeTypeName("const b2Circle *")] b2Circle* shape, float density);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2ComputeCapsuleMass([NativeTypeName("const b2Capsule *")] b2Capsule* shape, float density);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MassData b2ComputePolygonMass([NativeTypeName("const b2Polygon *")] b2Polygon* shape, float density);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2ComputeCircleAABB([NativeTypeName("const b2Circle *")] b2Circle* shape, b2Transform transform);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2ComputeCapsuleAABB([NativeTypeName("const b2Capsule *")] b2Capsule* shape, b2Transform transform);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2ComputePolygonAABB([NativeTypeName("const b2Polygon *")] b2Polygon* shape, b2Transform transform);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2AABB b2ComputeSegmentAABB([NativeTypeName("const b2Segment *")] b2Segment* shape, b2Transform transform);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2PointInCircle(b2Vec2 point, [NativeTypeName("const b2Circle *")] b2Circle* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2PointInCapsule(b2Vec2 point, [NativeTypeName("const b2Capsule *")] b2Capsule* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2PointInPolygon(b2Vec2 point, [NativeTypeName("const b2Polygon *")] b2Polygon* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2RayCastCircle([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("const b2Circle *")] b2Circle* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2RayCastCapsule([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("const b2Capsule *")] b2Capsule* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2RayCastSegment([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("const b2Segment *")] b2Segment* shape, [MarshalAs(UnmanagedType.I1)] bool oneSided);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2RayCastPolygon([NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("const b2Polygon *")] b2Polygon* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCastCircle([NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("const b2Circle *")] b2Circle* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCastCapsule([NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("const b2Capsule *")] b2Capsule* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCastSegment([NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("const b2Segment *")] b2Segment* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCastPolygon([NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("const b2Polygon *")] b2Polygon* shape);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Hull b2ComputeHull([NativeTypeName("const b2Vec2 *")] b2Vec2* points, [NativeTypeName("int32_t")] int count);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2ValidateHull([NativeTypeName("const b2Hull *")] b2Hull* hull);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2SegmentDistanceResult b2SegmentDistance(b2Vec2 p1, b2Vec2 q1, b2Vec2 p2, b2Vec2 q2);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2DistanceOutput b2ShapeDistance(b2DistanceCache* cache, [NativeTypeName("const b2DistanceInput *")] b2DistanceInput* input, b2Simplex* simplexes, int simplexCapacity);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2CastOutput b2ShapeCast([NativeTypeName("const b2ShapeCastPairInput *")] b2ShapeCastPairInput* input);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2DistanceProxy b2MakeProxy([NativeTypeName("const b2Vec2 *")] b2Vec2* vertices, [NativeTypeName("int32_t")] int count, float radius);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Transform b2GetSweepTransform([NativeTypeName("const b2Sweep *")] b2Sweep* sweep, float time);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2TOIOutput b2TimeOfImpact([NativeTypeName("const b2TOIInput *")] b2TOIInput* input);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideCircles([NativeTypeName("const b2Circle *")] b2Circle* circleA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideCapsuleAndCircle([NativeTypeName("const b2Capsule *")] b2Capsule* capsuleA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSegmentAndCircle([NativeTypeName("const b2Segment *")] b2Segment* segmentA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollidePolygonAndCircle([NativeTypeName("const b2Polygon *")] b2Polygon* polygonA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideCapsules([NativeTypeName("const b2Capsule *")] b2Capsule* capsuleA, b2Transform xfA, [NativeTypeName("const b2Capsule *")] b2Capsule* capsuleB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSegmentAndCapsule([NativeTypeName("const b2Segment *")] b2Segment* segmentA, b2Transform xfA, [NativeTypeName("const b2Capsule *")] b2Capsule* capsuleB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollidePolygonAndCapsule([NativeTypeName("const b2Polygon *")] b2Polygon* polygonA, b2Transform xfA, [NativeTypeName("const b2Capsule *")] b2Capsule* capsuleB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollidePolygons([NativeTypeName("const b2Polygon *")] b2Polygon* polygonA, b2Transform xfA, [NativeTypeName("const b2Polygon *")] b2Polygon* polygonB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSegmentAndPolygon([NativeTypeName("const b2Segment *")] b2Segment* segmentA, b2Transform xfA, [NativeTypeName("const b2Polygon *")] b2Polygon* polygonB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSmoothSegmentAndCircle([NativeTypeName("const b2SmoothSegment *")] b2SmoothSegment* smoothSegmentA, b2Transform xfA, [NativeTypeName("const b2Circle *")] b2Circle* circleB, b2Transform xfB);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSmoothSegmentAndCapsule([NativeTypeName("const b2SmoothSegment *")] b2SmoothSegment* smoothSegmentA, b2Transform xfA, [NativeTypeName("const b2Capsule *")] b2Capsule* capsuleB, b2Transform xfB, b2DistanceCache* cache);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Manifold b2CollideSmoothSegmentAndPolygon([NativeTypeName("const b2SmoothSegment *")] b2SmoothSegment* smoothSegmentA, b2Transform xfA, [NativeTypeName("const b2Polygon *")] b2Polygon* polygonB, b2Transform xfB, b2DistanceCache* cache);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2DynamicTree b2DynamicTree_Create();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_Destroy(b2DynamicTree* tree);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int32_t")]
        public static extern int b2DynamicTree_CreateProxy(b2DynamicTree* tree, b2AABB aabb, [NativeTypeName("uint32_t")] uint categoryBits, [NativeTypeName("int32_t")] int userData);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_DestroyProxy(b2DynamicTree* tree, [NativeTypeName("int32_t")] int proxyId);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_MoveProxy(b2DynamicTree* tree, [NativeTypeName("int32_t")] int proxyId, b2AABB aabb);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_EnlargeProxy(b2DynamicTree* tree, [NativeTypeName("int32_t")] int proxyId, b2AABB aabb);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_Query([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, b2AABB aabb, [NativeTypeName("uint32_t")] uint maskBits, [NativeTypeName("b2TreeQueryCallbackFcn *")] IntPtr callback, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_RayCast([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, [NativeTypeName("const b2RayCastInput *")] b2RayCastInput* input, [NativeTypeName("uint32_t")] uint maskBits, [NativeTypeName("b2TreeRayCastCallbackFcn *")] IntPtr callback, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_ShapeCast([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, [NativeTypeName("const b2ShapeCastInput *")] b2ShapeCastInput* input, [NativeTypeName("uint32_t")] uint maskBits, [NativeTypeName("b2TreeShapeCastCallbackFcn *")] IntPtr callback, void* context);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_Validate([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_GetHeight([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_GetMaxBalance([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2DynamicTree_GetAreaRatio([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_RebuildBottomUp(b2DynamicTree* tree);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_GetProxyCount([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_Rebuild(b2DynamicTree* tree, [MarshalAs(UnmanagedType.I1)] bool fullBuild);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2DynamicTree_ShiftOrigin(b2DynamicTree* tree, b2Vec2 newOrigin);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int b2DynamicTree_GetByteCount([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree);

        [return: NativeTypeName("int32_t")]
        public static int b2DynamicTree_GetUserData([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, [NativeTypeName("int32_t")] int proxyId)
        {
            return tree->nodes[proxyId].userData;
        }

        public static b2AABB b2DynamicTree_GetAABB([NativeTypeName("const b2DynamicTree *")] b2DynamicTree* tree, [NativeTypeName("int32_t")] int proxyId)
        {
            return tree->nodes[proxyId].aabb;
        }

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2IsValid(float a);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Vec2_IsValid(b2Vec2 v);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2Rot_IsValid(b2Rot q);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool b2AABB_IsValid(b2AABB aabb);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2Normalize(b2Vec2 v);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2NormalizeChecked(b2Vec2 v);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Vec2 b2GetLengthAndNormalize(float* length, b2Vec2 v);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void b2SetLengthUnitsPerMeter(float lengthUnits);

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float b2GetLengthUnitsPerMeter();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WorldDef b2DefaultWorldDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2BodyDef b2DefaultBodyDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2Filter b2DefaultFilter();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2QueryFilter b2DefaultQueryFilter();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ShapeDef b2DefaultShapeDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2ChainDef b2DefaultChainDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2DistanceJointDef b2DefaultDistanceJointDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MotorJointDef b2DefaultMotorJointDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2MouseJointDef b2DefaultMouseJointDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2PrismaticJointDef b2DefaultPrismaticJointDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2RevoluteJointDef b2DefaultRevoluteJointDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WeldJointDef b2DefaultWeldJointDef();

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern b2WheelJointDef b2DefaultWheelJointDef();
    }
}
