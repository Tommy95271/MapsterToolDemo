using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsterToolDemo.AttributeBase
{
    [AdaptTo("[name]Dto", MapToConstructor = true)]
    public class ReadonlyProp
    {
        public int Id { get; set; }
    }
}
