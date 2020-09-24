using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class PsnPaymentOption : PaymentOption
    {
        [ProtoMember(1)]
        public string ItemId { get; set; }
        [ProtoMember(2)]
        public string AuthorizationCode { get; set; }
        [ProtoMember(3)]
        public ulong ServiceLabel { get; set; }
        [ProtoMember(4)]
        public int PsnEnvironment { get; set; }
    }
}
