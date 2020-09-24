using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking
{
    [ProtoContract]
    public class QosResultDto
    {
        [ProtoMember(1)]
        public string RegionId { get; set; }
        [ProtoMember(2)]
        public float PacketLoss { get; set; }
        [ProtoMember(3)]
        public uint MillisecondLatency { get; set; }
    }
}
