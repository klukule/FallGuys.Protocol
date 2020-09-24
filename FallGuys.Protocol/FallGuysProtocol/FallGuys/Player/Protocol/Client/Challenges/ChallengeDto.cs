using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges
{

    [ProtoContract]
    public class ChallengeDto
    {
        [ProtoMember(1)]
        public string Id { get; set; }
        [ProtoMember(2)]
        public string ChallengeId { get; set; }
        [ProtoMember(3)]
        public int Progress { get; set; }
        [ProtoMember(4)]
        public int Goal { get; set; }
        [ProtoMember(5)]
        public string RewardId { get; set; }
    }
}
