using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements
{
    [ProtoContract]
    public class AchievementsCompletedNotificationDto
    {
        [ProtoMember(1)]
        public string Id { get; set; }
        [ProtoMember(2)]
        public List<AchievementDto> Achievements { get; set; }
    }
}
