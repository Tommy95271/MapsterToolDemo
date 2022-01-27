using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsterToolDemo.AttributeBase
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class ExtensionMethod
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
