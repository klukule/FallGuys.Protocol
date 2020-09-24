using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{
    [ProtoContract]
    public class StoreDto
    {
        [ProtoMember(1)]
        public List<StoreSectionDto> Sections { get; set; }
    }
}
