using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests.Admin
{
    [Authorize(Roles = new[] { "Super", "Admin" })]
    [ProtoContract]
    public class AdminUpdateAccountRequest
    {
        [ProtoMember(1)]
        public string AccountId { get; set; }
        [ProtoMember(2)]
        public bool IsBanned { get; set; }
        [ProtoMember(3)]
        public string Roles { get; set; }
    }
}
