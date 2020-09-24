using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Services.Login.Requests.Admin
{
    [ProtoContract]
    public class AdminRemoveIdentityRequest
    {
        [ProtoMember(1)]
        public string IdentityId { get; set; }
    }
}
