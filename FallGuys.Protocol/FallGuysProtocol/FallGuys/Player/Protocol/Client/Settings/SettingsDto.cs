using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Settings
{
    [ProtoContract]
    public class SettingsDto
    {
        [ProtoMember(1)]
        public Dictionary<string, string> Values { get; set; }
    }
}
