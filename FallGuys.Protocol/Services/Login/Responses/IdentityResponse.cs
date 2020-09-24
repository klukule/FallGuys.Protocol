using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Services.Login.Responses
{
    [ProtoContract]
    public class IdentityResponse
    {
        [ProtoMember(1)]
        public string Type { get; set; }
        [ProtoMember(2)]
        public string Token { get; set; }
        [ProtoMember(3)]
        public string Id { get; set; }
        [ProtoMember(4)]
        public string AccountId { get; set; }
    }
}
