using System;
using System.Collections.Generic;
using System.Text;
using FallGuys.Player.Protocol.Client.Rewards;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards
{
    [ProtoContract]
    public class UnclaimedRewardsDto
    {
        [ProtoMember(1)]
        public List<RewardDto> Rewards { get; set; }
    }
}
