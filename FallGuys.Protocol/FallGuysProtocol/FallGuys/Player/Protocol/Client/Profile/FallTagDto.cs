using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile
{
    [ProtoContract]
    public class FallTagDto
    {
        [ProtoMember(1)]
        public string FirstPart { get; set; }
        [ProtoMember(2)]
        public string LastPart { get; set; }
        [ProtoMember(3)]
        public string Id { get; set; }
    }
}
