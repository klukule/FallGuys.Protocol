using System;
using System.Collections.Generic;
using System.Text;
using FallGuys.Player.Protocol.Client.Rewards;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes
{
    [ProtoContract]
    public class SeasonProgressDto
    {
        [ProtoMember(1)]
        public Dictionary<int, RewardDto> FameTiersUnlocked { get; set; }
    }
}
