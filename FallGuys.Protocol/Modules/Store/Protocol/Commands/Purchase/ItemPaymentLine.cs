using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class ItemPaymentLine
    {
        [ProtoMember(1)]
        public string ItemId { get; set; }
        [ProtoMember(2)]
        public int Quantity { get; set; }
    }

}
