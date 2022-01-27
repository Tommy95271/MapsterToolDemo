using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MapsterToolDemo.AttributeBase
{
    [AdaptTo("[name]Dto", IgnoreAttributes = new[] { typeof(DataMemberAttribute) })]
    internal class IgnoreAttributes
    {
        [DataMember]
        public string IgnoredProp { get; set; }
        public string NotIgnoredProp { get; set; }

    }
}
