using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons
{
    [ProtoContract]
    public class SeasonCompletedDto
    {
        [ProtoMember(1)]
        public string SeasonId { get; set; }
    }
}
