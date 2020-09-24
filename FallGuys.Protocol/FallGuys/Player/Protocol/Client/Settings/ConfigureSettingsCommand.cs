using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Settings
{
    [Authorize(Roles = new []{"User"})]
    [ProtoContract]
    public class ConfigureSettingsCommand
    {
        [ProtoMember(1)]
        public Dictionary<string, string> Values { get; set; }
    }
}
