using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics
{

    [ProtoContract]
    public class NicknameDto
    {
        [ProtoMember(1)]
        public ItemDto Item { get; set; }
        [ProtoMember(2)]
        public DateTime EarnedAt { get; set; }
    }
}
