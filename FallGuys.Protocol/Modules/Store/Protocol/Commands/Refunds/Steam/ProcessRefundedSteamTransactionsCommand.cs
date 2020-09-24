using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Refunds.Steam
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class ProcessRefundedSteamTransactionsCommand
    {
        [ProtoMember(1)]
        public Order Orders { get; set; }
    }
}
