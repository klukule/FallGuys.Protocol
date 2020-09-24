using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Services.Login.Responses
{
    [ProtoContract]
    public class SessionTokenResponse
    {
        [ProtoMember(1)]
        public string SessionToken { get; set; }
        [ProtoMember(2)]
        public string AccountId { get; set; }
        [ProtoMember(3)]
        public string[] Roles { get; set; }
        [ProtoMember(4)]
        public string ContentUrl { get; set; }
        [ProtoMember(5)]
        public string ContentVersion { get; set; }
        [ProtoMember(6)]
        public string ContentEtag { get; set; }
        [ProtoMember(7)]
        public string AnalyticsId { get; set; }
        [ProtoMember(8)]
        public Dictionary<string, string> ExtraIdentities { get; set; }
    }
}
