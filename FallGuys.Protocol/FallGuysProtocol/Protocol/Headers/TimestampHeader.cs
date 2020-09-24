using System;
using ProtoBuf;

namespace Catapult.Protocol.Headers
{
    [ProtoContract]
    public class TimestampHeader : MessageHeader
    {
        [ProtoMember(1)]
        public DateTime Utc { get; set; }

        public TimestampHeader()
        {

        }

        public override string ToString()
        {
            return $"TimestampHeader<Utc:{Utc}>";
        }
    }
}
