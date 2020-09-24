using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Dtos
{
    [ProtoContract]
    public class StoreBundleItemDto
    {
        [ProtoMember(1)]
        public string ContentType { get; set; }
        [ProtoMember(2)]
        public string ContentId { get; set; }
        [ProtoMember(3)]
        public int Quantity { get; set; }
    }
}
