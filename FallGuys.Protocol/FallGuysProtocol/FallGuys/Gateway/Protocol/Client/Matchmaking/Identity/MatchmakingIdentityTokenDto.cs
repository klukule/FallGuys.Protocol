using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Identity
{
    [ProtoContract]
    public class MatchmakingIdentityTokenDto
    {
        [ProtoMember(1)]
        public string Value { get; set; }
    }
}
