using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class ItemPaymentOption
    {
        [ProtoMember(1)]
        public string StoreId { get; set; }
        [ProtoMember(2)]
        public string StoreSectionId { get; set; }
        [ProtoMember(3)]
        public string StoreBundleId { get; set; }
        [ProtoMember(4)]
        public ItemPaymentLine Lines { get; set; }
    }
}
