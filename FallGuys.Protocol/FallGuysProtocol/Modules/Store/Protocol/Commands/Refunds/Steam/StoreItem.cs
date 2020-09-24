using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Refunds.Steam
{
    [ProtoContract]
    public class StoreItem
    {
        [ProtoMember(1)]
        public ulong ItemId { get; set; }
        [ProtoMember(2)]
        public ulong Quantity { get; set; }
        [ProtoMember(3)]
        public ulong Amount { get; set; }
        [ProtoMember(4)]
        public string ItemStatus { get; set; }
        [ProtoMember(5)]
        public ulong Vat { get; set; }
        [ProtoMember(6)]
        public string Description { get; set; }
    }
}
