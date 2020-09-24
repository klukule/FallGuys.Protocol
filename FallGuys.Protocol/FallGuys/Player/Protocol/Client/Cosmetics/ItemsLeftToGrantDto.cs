using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics
{

    [ProtoContract]
    public class ItemsLeftToGrantDto
    {
        [ProtoMember(1)]
        public int ItemsLeftToGrant { get; set; }
        [ProtoMember(2)]
        public List<ItemAddedDto> ItemsGranted { get; set; }
    }
}
