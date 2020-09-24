using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Services.Login.Responses
{
    [ProtoContract]
    public class LookupIdentityResponse
    {
        [ProtoMember(1)]
        public string AccountId { get; set; }
    }
}
