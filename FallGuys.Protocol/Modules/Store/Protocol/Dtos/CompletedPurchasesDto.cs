using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{
    [ProtoContract]
    public class CompletedPurchasesDto
    {
        [ProtoMember(1)]
        public List<CompletedPurchaseDto> PurchaseDtos { get; set; }
    }
}
