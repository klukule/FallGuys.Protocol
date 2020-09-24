using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons
{
    [ProtoContract]
    public class PlayerSeasonDto
    {
        [ProtoMember(1)]
        public SeasonRecordDto CurrentSeason { get; set; }
        [ProtoMember(2)]
        public int AccumulatedFame { get; set; }
        [ProtoMember(3)]
        public List<SeasonRecordDto> PreviousSeasons { get; set; }
    }
}
