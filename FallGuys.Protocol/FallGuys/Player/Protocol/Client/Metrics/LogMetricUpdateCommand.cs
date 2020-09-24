using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Metrics
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class LogMetricUpdateCommand
    {
        [ProtoMember(1)]
        public Dictionary<string, MetricUpdateDto> MetricUpdates { get; set; }
    }
}
