using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests.Admin
{
    [Authorize(Roles = new[] { "Super", "Admin" })]
    [ProtoContract]
    public class AdminMigrateAccountRequest
    {
        [ProtoMember(1)]
        public string NewOwningAccount { get; set; }
        [ProtoMember(2)]
        public string PreviousOwningAccount { get; set; }
    }
}
