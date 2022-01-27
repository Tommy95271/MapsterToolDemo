using MapsterToolDemo.AttributeBase;

namespace MapsterToolDemo.AttributeBase
{
    public static partial class ExtensionMethodMapper
    {
        public static ExtensionMethodDto AdaptToDto(this ExtensionMethod p1)
        {
            return p1 == null ? null : new ExtensionMethodDto() {};
        }
        public static ExtensionMethodDto AdaptTo(this ExtensionMethod p2, ExtensionMethodDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            ExtensionMethodDto result = p3 ?? new ExtensionMethodDto();
            return result;
            
        }
    }
}