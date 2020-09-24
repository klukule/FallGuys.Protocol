using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.PlayerDisconnected
{
    [ProtoContract]
    public class GameServerDisconnectNotification
    {
        [ProtoMember(1)]
        public string PlayerId { get; set; }
        [ProtoMember(2)]
        public int ErrorCode { get; set; }
        [ProtoMember(3)]
        public DateTime TimeStamp { get; set; }
    }
}
