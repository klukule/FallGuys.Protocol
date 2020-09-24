using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Playtime
{
    [ProtoContract]
    public class PlaytimeWarningDto
    {
        [ProtoMember(1)]
        public string MonitoringTierId { get; set; }
    }
}
