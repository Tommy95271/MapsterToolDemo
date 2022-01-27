using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsterToolDemo.AttributeBase
{
    [AdaptFrom("[name]Merge", IgnoreNullValues = true)]
    public class NullableProp
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
