using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests
{
    [Authorize(AllowAnonymous = true)]
    [ProtoContract]
    public class AddIdentityRequest
    {
        [ProtoMember(1)]
        public string ExistingIdentityType { get; set; }
        [ProtoMember(2)]
        public string ExistingIdentityToken { get; set; }
        [ProtoMember(3)]
        public Dictionary<string, string> ExistingIdentityProperties { get; set; }
        [ProtoMember(4)]
        public string NewIdentityType { get; set; }
        [ProtoMember(5)]
        public string NewIdentityToken { get; set; }
        [ProtoMember(6)]
        public Dictionary<string, string> NewIdentityProperties { get; set; }
    }
}
