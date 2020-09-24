using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes
{
    [ProtoContract]
    public class EpisodeHistoryDto
    {
        [ProtoMember(1)]
        public int CurrentStreak { get; set; }
        [ProtoMember(2)]
        public int HighestStreak { get; set; }
    }
}
