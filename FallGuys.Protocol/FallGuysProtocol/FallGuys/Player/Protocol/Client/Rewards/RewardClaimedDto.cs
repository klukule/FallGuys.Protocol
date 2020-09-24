using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards
{
    [ProtoContract]
    public class RewardClaimedDto
    {
        [ProtoMember(1)]
        public List<ItemAddedDto> ItemsGained { get; set; }
        [ProtoMember(2)]
        public List<ItemRemovedDto> ItemsLost { get; set; }
    }
}
