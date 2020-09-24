using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{
    [ProtoContract]
    public class ItemPaymentDto
    {
        [ProtoMember(1)]
        public List<ItemPaymentLineDto> Items { get; set; }
    }
}
