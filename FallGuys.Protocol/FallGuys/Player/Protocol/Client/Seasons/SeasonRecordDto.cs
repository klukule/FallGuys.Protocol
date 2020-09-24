using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons
{
    [ProtoContract]
    public class SeasonRecordDto
    {
        [ProtoMember(1)]
        public string SeasonId { get; set; }
        [ProtoMember(2)]
        public int AccruedFame { get; set; }
        [ProtoMember(3)]
        public List<SeasonFameTierDto> FameTiers { get; set; }
    }
}
