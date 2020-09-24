using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Services.Login.Responses
{
    [ProtoContract]
    public class AccountsResponse
    {
        [ProtoMember(1)]
        public List<AccountResponse> Accounts { get; set; }
        [ProtoMember(2)]
        public int Total { get; set; }
    }
}
