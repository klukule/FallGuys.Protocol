using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons
{
    [ProtoContract]
    public class SeasonFameTierDto
    {
        [ProtoMember(1)]
        public int Index { get; set; }
        [ProtoMember(2)]
        public int FameRequired { get; set; }
        [ProtoMember(3)]
        public bool IsUnlocked { get; set; }
        [ProtoMember(4)]
        public string RewardId { get; set; }
        [ProtoMember(5)]
        public bool IsAcknowledged { get; set; }
    }
}
