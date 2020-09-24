using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes
{

    [ProtoContract]
    public class RoundReportDto
    {
        [ProtoMember(1)]
        public int RoundIndex { get; set; }
        [ProtoMember(2)]
        public string BadgeId { get; set; }
        [ProtoMember(3)]
        public string LevelId { get; set; }
        [ProtoMember(4)]
        public int? BonusTierIndex { get; set; }
    }
}
