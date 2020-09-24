using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace FallGuys.Player.Protocol.Client.Profile
{
    [ProtoContract]
    public class ProfileDto
    {
        [ProtoMember(1)]
        public string Id { get; set; }
        [ProtoMember(2)]
        public FallTagDto FallTag { get; set; }
    }
}
