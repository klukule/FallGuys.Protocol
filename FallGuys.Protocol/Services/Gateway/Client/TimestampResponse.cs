using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Services.Gateway.Client
{
    [ProtoContract]
    public class TimestampResponse
    {
        [ProtoMember(1)]
        public DateTime Utc { get; set; }
    }
}
