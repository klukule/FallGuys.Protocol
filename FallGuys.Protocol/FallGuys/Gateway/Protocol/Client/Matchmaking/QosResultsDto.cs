using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking
{
    [ProtoContract]
    public class QosResultsDto
    {
        [ProtoMember(1)]
        public List<QosResultDto> QoSResults { get; set; }
    }
}
