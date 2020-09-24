using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking
{
    [ProtoContract]
    public class MatchmakingSessionDto
    {
        [ProtoMember(1)]
        public DateTime? StartsAt { get; set; }
        [ProtoMember(2)]
        public DateTime? EndsAt { get; set; }
    }
}
