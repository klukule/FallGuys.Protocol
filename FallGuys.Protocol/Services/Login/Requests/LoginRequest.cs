using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests
{
    [Authorize(AllowAnonymous = true)]
    [ProtoContract]
    public class LoginRequest
    {
        [ProtoMember(1)]
        public string IdentityType { get; set; }
        [ProtoMember(2)]
        public string IdentityToken { get; set; }
        [ProtoMember(3)]
        public string ClientVersion { get; set; }
        [ProtoMember(4)]
        public string ContentETag { get; set; }
        [ProtoMember(5)]
        public string Platform { get; set; }
        [ProtoMember(6)]
        public Dictionary<string, string> UserParameters { get; set; }
        [ProtoMember(7)]
        public Dictionary<string,string> Properties { get; set; }
    }
}
