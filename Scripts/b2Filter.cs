namespace Box2D
{
    public partial struct b2Filter
    {
        [NativeTypeName("uint32_t")]
        public uint categoryBits;

        [NativeTypeName("uint32_t")]
        public uint maskBits;

        [NativeTypeName("int32_t")]
        public int groupIndex;
    }
}
