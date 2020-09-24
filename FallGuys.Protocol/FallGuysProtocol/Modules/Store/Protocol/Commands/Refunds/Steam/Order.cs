using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Refunds.Steam
{
    [ProtoContract]
    public class Order
    {
        [ProtoMember(1)]
        public ulong OrderId { get; set; }
        [ProtoMember(2)]
        public ulong TransactionId { get; set; }
        [ProtoMember(3)]
        public ulong SteamId { get; set; }
        [ProtoMember(4)]
        public string Status { get; set; }
        [ProtoMember(5)]
        public DateTime TransactionTime { get; set; }
        [ProtoMember(6)]
        public StoreItem Items { get; set; }
    }
}
