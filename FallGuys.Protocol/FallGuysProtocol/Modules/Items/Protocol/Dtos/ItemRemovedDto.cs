using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Items.Protocol.Dtos
{
    [ProtoContract]
    public class ItemRemovedDto
    {
        [ProtoMember(1)]
        public string Id { get; set; }
        [ProtoMember(2)]
        public string ContentId { get; set; }
        [ProtoMember(3)]
        public string ContentType { get; set; }
        [ProtoMember(4)]
        public List<ItemChangedDto> Changes { get; set; }
    }
}
