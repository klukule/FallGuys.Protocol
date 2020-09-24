using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements
{
    [ProtoContract]
    public class AchievementsDto
    {
        [ProtoMember(1)]
        public List<AchievementDto> Achievements { get; set; }
    }
}
