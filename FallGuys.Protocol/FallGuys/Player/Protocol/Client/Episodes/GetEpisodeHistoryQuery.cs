using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class GetEpisodeHistoryQuery
    {
    }

}
