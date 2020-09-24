using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests.Admin
{
    [Authorize(Roles = new[] { "Admin", "Super" })]
    [ProtoContract]
    public class AdminGetIdentitiesRequest
    {
        [ProtoMember(1)]
        public string AccountId { get; set; }
    }
}
