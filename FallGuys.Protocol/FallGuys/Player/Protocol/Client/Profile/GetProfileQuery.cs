using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;

namespace FallGuys.Player.Protocol.Client.Profile
{
    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class GetProfileQuery
    {
    }
}
