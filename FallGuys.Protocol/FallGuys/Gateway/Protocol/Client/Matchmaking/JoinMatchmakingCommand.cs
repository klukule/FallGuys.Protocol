using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class JoinMatchmakingCommand
    {
        [ProtoMember(1)]
        public string CompanionIdentities { get; set; }
        [ProtoMember(2)]
        public QosResultsDto QosResults { get; set; }
        [ProtoMember(3)]
        public string EntryCode { get; set; }
    }
}
