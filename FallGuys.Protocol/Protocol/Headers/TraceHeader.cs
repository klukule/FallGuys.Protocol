using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol.Headers
{
    [ProtoContract]
    public class TraceHeader : MessageHeader
    {
        [ProtoMember(1)]
        public long TraceId { get; set; }
        
        [ProtoMember(2)]
        public long? ParentSpanId { get; set; }
        
        
        [ProtoMember(3)]
        public long SpanId { get; set; }
        
        [ProtoMember(4)]
        public bool Sampled { get; set; }

        [ProtoMember(5)]
        public bool Debug { get; set; }

        public TraceHeader()
        {
            
        }
    }
}
