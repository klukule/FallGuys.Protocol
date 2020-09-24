using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{
    [ProtoContract]
    public class CompletedPurchaseDto
    {
        [ProtoMember(1)]
        public List<ItemAddedDto> Items { get; set; }
        [ProtoMember(2)]
        public List<StoreBundleDto> PurchasedBundles { get; set; }
    }
}
