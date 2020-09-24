using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class InitSteamTransactionCommand
    {
        [ProtoMember(1)]
        public string IapId { get; set; }
        [ProtoMember(2)]
        public ulong SteamId { get; set; }
    }
}
