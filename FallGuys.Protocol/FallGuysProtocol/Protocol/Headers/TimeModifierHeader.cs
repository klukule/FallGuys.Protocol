using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol.Headers
{
    [ProtoContract]
    public class TimeModifierHeader : MessageHeader
    {
        [ProtoMember(1)]
        public TimeSpan TimeModifier { get; set; }

        public TimeModifierHeader(TimeSpan timeModifier)
        {
            TimeModifier = timeModifier;
        }
    }
}
