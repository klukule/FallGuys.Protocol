using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{

    [ProtoContract]
    public class StoreBundleDto
    {
        [ProtoMember(1)]
        public string Id { get; set; }
        [ProtoMember(2)]
        public List<PaymentDto> PaymentOptions { get; set; }
        [ProtoMember(3)]
        public StoreBundleRewardDto Reward { get; set; }
        [ProtoMember(4)]
        public string CategoryName { get; set; }
        [ProtoMember(5)]
        public int? Stock { get; set; }
        [ProtoMember(6)]
        public DateTime? AvailableTo { get; set; }
    }
}
