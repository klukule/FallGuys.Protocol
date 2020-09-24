using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{
    [ProtoContract]
    public class ItemPaymentLineDto
    {
        [ProtoMember(1)]
        public string Type { get; set; }
        [ProtoMember(2)]
        public string Id { get; set; }
        [ProtoMember(3)]
        public int Quantity { get; set; }
    }
}
