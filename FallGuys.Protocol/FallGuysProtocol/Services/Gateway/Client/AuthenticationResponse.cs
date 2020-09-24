using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Services.Gateway.Client
{
    [ProtoContract]
    public class AuthenticationResponse
    {
        [ProtoMember(1)]
        public string UserId { get; set; }
    }
}
