using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{
    [ProtoContract]
    public class IapPaymentDto
    {
        [ProtoMember(1)]
        public string IapId { get; set; }
    }
}
