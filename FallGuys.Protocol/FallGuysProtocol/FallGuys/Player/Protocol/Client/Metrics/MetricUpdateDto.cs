using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Metrics
{
    [ProtoContract]
    public class MetricUpdateDto
    {
        [ProtoMember(1)]
        public string MetricId { get; set; }
        [ProtoMember(2)]
        public Dictionary<string, string> Dimensions { get; set; }
        [ProtoMember(3)]
        public int Value { get; set; }
    }
}
