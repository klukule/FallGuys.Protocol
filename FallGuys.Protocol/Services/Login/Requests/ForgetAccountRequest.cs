using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests
{
    [Authorize(AllowAnonymous = true)]
    [ProtoContract]
    public class ForgetAccountRequest
    {
        [ProtoMember(1)]
        public string IdentityType { get; set; }
        [ProtoMember(2)]
        public string IdentityToken { get; set; }
        [ProtoMember(3)]
        public Dictionary<string, string> IdentityProperties { get; set; }
    }
}
