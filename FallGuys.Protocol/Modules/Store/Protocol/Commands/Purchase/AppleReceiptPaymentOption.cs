using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class AppleReceiptPaymentOption : PaymentOption
    {
        [ProtoMember(1)]
        public string Receipt { get; set; }
    }

}
