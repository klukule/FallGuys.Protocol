using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Gateway.Protocol.Client
{
    [ProtoContract]
    [Authorize(AllowAnonymous = true)]
    public class AuthenticationRequest
    {
        [ProtoMember(1)]
        public string Token { get; set; }
        [ProtoMember(2)]
        public string ContentEtag { get; set; }
        [ProtoMember(3)]
        public string ProtocolVersion { get; set; }
        [ProtoMember(4)]
        public bool ContinueSession { get; set; }
    }
}
