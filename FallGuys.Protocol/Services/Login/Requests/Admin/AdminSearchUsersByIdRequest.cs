using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests.Admin
{
    [Authorize(Roles = new[] { "Super", "Admin" })]
    [ProtoContract]
    public class AdminSearchUsersByIdRequest
    {
        [ProtoMember(1)]
        public string AccountId { get; set; }
        [ProtoMember(2)]
        public int Page { get; set; }
        [ProtoMember(3)]
        public int Count { get; set; }
    }
}
