using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class SteamTransactionResult
    {
        [ProtoMember(1)]
        public ulong TransactionId { get; set; }
        [ProtoMember(2)]
        public ulong OrderId { get; set; }
    }
}
