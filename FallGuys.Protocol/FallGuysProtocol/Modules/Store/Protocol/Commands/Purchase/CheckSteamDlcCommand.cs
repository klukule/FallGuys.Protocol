using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Modules.Store.Protocol.Commands.Purchase
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class CheckSteamDlcCommand
    {
    }
}
