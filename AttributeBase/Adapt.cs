using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeBase
{
    [AdaptTo("[name]Dto")]
    internal class Adapt
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
