using System;
using System.Runtime.InteropServices;

namespace Box2D
{
    public unsafe partial struct b2WorldDef
    {
        public b2Vec2 gravity;

        public float restitutionThreshold;

        public float contactPushoutVelocity;

        public float hitEventThreshold;

        public float contactHertz;

        public float contactDampingRatio;

        public float jointHertz;

        public float jointDampingRatio;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableSleep;

        [MarshalAs(UnmanagedType.I1)]
        public bool enableContinous;

        [NativeTypeName("int32_t")]
        public int workerCount;

        [NativeTypeName("b2EnqueueTaskCallback *")]
        public IntPtr enqueueTask;

        [NativeTypeName("b2FinishTaskCallback *")]
        public IntPtr finishTask;

        public void* userTaskContext;

        [NativeTypeName("int32_t")]
        public int internalValue;
    }
}
