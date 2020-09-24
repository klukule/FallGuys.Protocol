using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class AndroidReceiptPaymentOption : PaymentOption
    {
        [ProtoMember(1)]
        public string Receipt { get; set; }
        [ProtoMember(2)]
        public string Signature { get; set; }
    }
}
