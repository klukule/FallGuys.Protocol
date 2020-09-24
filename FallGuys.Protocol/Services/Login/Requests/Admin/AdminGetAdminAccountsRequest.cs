using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Requests.Admin
{
    [Authorize(Roles = new[] { "Admin", "Super" })]
    [ProtoContract]
    public class AdminGetAdminAccountsRequest
    {
        [ProtoMember(1)]
        public int Page { get; set; }
        [ProtoMember(2)]
        public int Count { get; set; }
    }
}
