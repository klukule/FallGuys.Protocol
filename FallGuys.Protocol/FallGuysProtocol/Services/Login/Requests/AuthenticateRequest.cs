using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests
{
    [Authorize(AllowAnonymous = true)]
    [ProtoContract]
    public class AuthenticateRequest
    {
        [ProtoMember(1)]
        public string Token { get; set; }
    }
}
