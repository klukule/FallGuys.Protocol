using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking
{
    [Authorize(Roles = new []{"User"})]
    [ProtoContract]
    public class CancelMatchmakingCommand
    {
    }
}
