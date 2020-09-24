using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class PurchaseBundleCommand
    {
        [ProtoMember(1)]
        public PaymentOption Payment { get; set; }
    }
}
