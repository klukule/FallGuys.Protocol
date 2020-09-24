using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [ProtoContract]
    public class ProcessPendingPsnDlcPurchasesCommand
    {
        [ProtoMember(1)]
        public string AuthCode { get; set; }
        [ProtoMember(2)]
        public ulong ServiceLabel { get; set; }
        [ProtoMember(3)]
        public int PsnEnvironment { get; set; }
    }
}
