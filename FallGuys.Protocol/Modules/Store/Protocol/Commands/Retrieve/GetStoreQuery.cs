using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Retrieve
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class GetStoreQuery
    {
        [ProtoMember(1)]
        public string StoreId { get; set; }
    }
}
