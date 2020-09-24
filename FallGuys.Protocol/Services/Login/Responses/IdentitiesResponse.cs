using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Services.Login.Responses
{
    [ProtoContract]
    public class IdentitiesResponse
    {
        [ProtoMember(1)]
        public List<IdentityResponse> Identities { get; set; }
    }
}
