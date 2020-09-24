using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes
{
    [ProtoContract]
    public class CompletedRoundDto
    {
        [ProtoMember(1)]
        public int RoundIndex { get; set; }
        [ProtoMember(2)]
        public int? TeamScore { get; set; }
        [ProtoMember(3)]
        public int? Position { get; set; }
        [ProtoMember(4)]
        public bool Qualified { get; set; }
        [ProtoMember(5)]
        public ItemAddedDto BonusKudos { get; set; }
        [ProtoMember(6)]
        public ItemAddedDto FameEarned { get; set; }
        [ProtoMember(7)]
        public ItemAddedDto KudosEarned { get; set; }
        [ProtoMember(8)]
        public int? TeamPosition { get; set; }
        [ProtoMember(9)]
        public ItemAddedDto BonusFameEarned { get; set; }
        [ProtoMember(10)]
        public int? FinishedInPositionBracket { get; set; }
        [ProtoMember(11)]
        public string BadgeId { get; set; }
        [ProtoMember(12)]
        public int? BonusTierIndex { get; set; }
        [ProtoMember(13)]
        public string LevelId { get; set; }
    }
}
