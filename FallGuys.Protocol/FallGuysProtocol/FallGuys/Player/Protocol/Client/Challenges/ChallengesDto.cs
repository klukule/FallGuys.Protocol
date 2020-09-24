using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges
{
    [ProtoContract]
    public class ChallengesDto
    {
        [ProtoMember(1)]
        public List<ChallengeDto> Challenges { get; set; }
        [ProtoMember(2)]
        public DateTime NextRefreshAfter { get; set; }
    }
}
