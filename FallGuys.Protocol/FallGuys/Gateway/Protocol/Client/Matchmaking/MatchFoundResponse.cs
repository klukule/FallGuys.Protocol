using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking
{
    [ProtoContract]
    public class MatchFoundResponse
    {
        [ProtoMember(1)]
        public string ServerAddress { get; set; }
        [ProtoMember(3)]
        public string ServerIp { get; set; }
        [ProtoMember(4)]
        public string ServerPort { get; set; }
        [ProtoMember(5)]
        public string PartyLeaderEntryToken { get; set; }
        [ProtoMember(2)]
        public Dictionary<string, string> CompanionEntryTokensByIdentity { get; set; }
    }
}
