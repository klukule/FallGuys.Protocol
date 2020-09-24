using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Dailies
{
    [ProtoContract]
    public class DailyDto
    {
        [ProtoMember(1)]
        public string Id { get; set; }
        [ProtoMember(2)]
        public string DailyId { get; set; }
        [ProtoMember(3)]
        public int Progress { get; set; }
        [ProtoMember(4)]
        public int Goal { get; set; }
        [ProtoMember(5)]
        public string RewardId { get; set; }
        [ProtoMember(6)]
        public DateTime? CompletedAt { get; set; }
    }
}
