using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Dailies
{
    [ProtoContract]
    public class DailiesDto
    {
        [ProtoMember(1)]
        public List<DailyDto> Dailies { get; set; }
        [ProtoMember(2)]
        public DateTime NextRefreshAfter { get; set; }
    }
}
