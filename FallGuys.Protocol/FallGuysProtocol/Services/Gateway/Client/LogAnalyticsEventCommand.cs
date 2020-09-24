using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Gateway.Client
{
    [Authorize(AllowAnonymous = true)]
    [ProtoContract]
    public class LogAnalyticsEventCommand
    {
        [ProtoMember(1)]
        public string EventType { get; set; }
        [ProtoMember(2)]
        public string EventProperties { get; set; }
        [ProtoMember(3)]
        public string AppVersion { get; set; }
        [ProtoMember(4)]
        public string Platform { get; set; }
        [ProtoMember(5)]
        public int QueueDuration { get; set; }
        [ProtoMember(6)]
        public DateTime ClientTimeUtc { get; set; }
        [ProtoMember(7)]
        public DateTimeOffsetSurrogate ClientTimeLocal { get; set; }
    }
}
