using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class SteamPaymentOption : PaymentOption
    {
        [ProtoMember(1)]
        public ulong OrderId { get; set; }
        [ProtoMember(2)]
        public ulong TransId { get; set; }
        [ProtoMember(3)]
        public ulong SteamId { get; set; }
    }

}
