using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class CreateGameEntryTokenCommand
    {
        [ProtoMember(1)]
        public string ServerIp { get; set; }
        [ProtoMember(2)]
        public int ServerPort { get; set; }
        [ProtoMember(3)]
        public string CompanionIdentities { get; set; }
        [ProtoMember(4)]
        public QosResultsDto QosResults { get; set; }
    }
}
