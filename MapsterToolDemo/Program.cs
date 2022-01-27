using MapsterToolDemo.AttributeBase;
using System;

namespace MapsterToolDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var extensionMethod = new ExtensionMethod() { LastName = "Tom", FirstName = "Cruise" };
            var extensionMethodDto = ExtensionMethodMapper.AdaptToDto(extensionMethod);
            var extensionMethodDto2 = ExtensionMethodMapper.AdaptTo(extensionMethod, null);
            Console.ReadLine();

        }
    }
}
