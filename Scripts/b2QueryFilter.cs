namespace Box2D
{
    public partial struct b2QueryFilter
    {
        [NativeTypeName("uint32_t")]
        public uint categoryBits;

        [NativeTypeName("uint32_t")]
        public uint maskBits;
    }
}
