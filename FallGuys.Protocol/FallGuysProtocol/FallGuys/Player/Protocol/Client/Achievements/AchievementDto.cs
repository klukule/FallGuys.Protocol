using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements
{
    [ProtoContract]
    public class AchievementDto
    {
        [ProtoMember(1)]
        public string Id { get; set; }
        [ProtoMember(2)]
        public string AchievementId { get; set; }
        [ProtoMember(3)]
        public DateTime? CompletedAt { get; set; }
        [ProtoMember(4)]
        public int Progress { get; set; }
    }
}
