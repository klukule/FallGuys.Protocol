using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Wallet
{
    [ProtoContract]
    public class WalletDto
    {
        [ProtoMember(1)]
        public int Kudos { get; set; }
        [ProtoMember(2)]
        public int Crowns { get; set; }
    }
}
