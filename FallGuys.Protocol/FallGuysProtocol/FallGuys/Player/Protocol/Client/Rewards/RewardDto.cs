using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards
{
    [ProtoContract]
    public class RewardDto
    {
        [ProtoMember(1)]
        public string Id { get; set; }
        [ProtoMember(2)]
        public string ContentReference { get; set; }
        [ProtoMember(3)]
        public DateTime EarnedAt { get; set; }
    }
}
