using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{
    [ProtoContract]
    public class StoreBundleRewardDto
    {
        [ProtoMember(1)]
        public List<StoreBundleItemDto> Items { get; set; }
    }
}
