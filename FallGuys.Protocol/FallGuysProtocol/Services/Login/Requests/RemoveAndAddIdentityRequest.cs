using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests
{
    [Authorize(AllowAnonymous = true)]
    [ProtoContract]
    public class RemoveAndAddIdentityRequest
    {
        [ProtoMember(1)]
        public string RemoveIdentityType { get; set; }
        [ProtoMember(2)]
        public string RemoveIdentityToken { get; set; }
        [ProtoMember(3)]
        public Dictionary<string, string> RemoveIdentityProperties { get; set; }
        [ProtoMember(4)]
        public string AddIdentityType { get; set; }
        [ProtoMember(5)]
        public string AddIdentityToken { get; set; }
        [ProtoMember(6)]
        public Dictionary<string, string> AddIdentityProperties { get; set; }
    }
}
