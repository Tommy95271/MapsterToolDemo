using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MapsterToolDemo.AttributeBase
{
    [AdaptTo("[name]Dto", IgnoreNoAttributes = new[] { typeof(DataMemberAttribute) })]
    internal class IgnoreNoAttributes
    {
        [DataMember]
        public string NotIgnoredProp { get; set; }

        public string IgnoredProp { get; set; }
    }
}
