using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class ClaimRewardCommand
    {
        [ProtoMember(1)]
        public string RewardId { get; set; }
        [ProtoMember(2)]
        public string Choice { get; set; }
    }
}
