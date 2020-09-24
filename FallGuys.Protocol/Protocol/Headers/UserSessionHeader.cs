using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol.Headers
{
    [ProtoContract]
    public class UserSessionHeader : MessageHeader
    {
        [ProtoMember(1)]
        public string UserId { get; set; }
        [ProtoMember(2)]
        public string[] Roles { get; set; }
        [ProtoMember(3)]
        public ContentTargeting ContentTargeting { get; set; }
        [ProtoMember(4)]
        public string[] IdentityTypes { get; set; }
        [ProtoMember(5)]
        public string AnalyticsId { get; set; }
        [ProtoMember(6)]
        public Dictionary<string, string> ExtraIdentities { get; set; }
        [ProtoMember(7)]
        public Dictionary<string, string> AdditionalProperties { get; set; }

        public override string ToString()
        {
            return $"UserSessionHeader: {UserId} ({(Roles == null ? "" : string.Join(",", Roles))}) [{ContentTargeting}]";
        }
    }
}
