using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol.Headers
{
    [ProtoContract]
    public class CorrelationHeader : MessageHeader
    {
        [ProtoMember(1)]
        public Guid ActivityId { get; set; }

        public CorrelationHeader()
        {
            
        }

        public CorrelationHeader(Guid activityId)
        {
            ActivityId = activityId;
        }

        public override string ToString()
        {
            return $"CorrelationHeader<ActivityId:{ActivityId}>";
        }
    }
}
