using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Modules.Items.Protocol.Dtos;
using FallGuys.Player.Protocol.Client.Challenges;
using FallGuys.Player.Protocol.Client.Dailies;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes
{
    [ProtoContract]
    public class CompletedEpisodeDto
    {
        [ProtoMember(1)]
        public string EpisodeId { get; set; }
        [ProtoMember(2)]
        public ItemAddedDto CrownsEarned { get; set; }
        [ProtoMember(3)]
        public List<CompletedRoundDto> Rounds { get; set; }
        [ProtoMember(4)]
        public SeasonProgressDto SeasonProgress { get; set; }
        [ProtoMember(5)]
        public DailiesDto Dailies { get; set; }
        [ProtoMember(6)]
        public ChallengesDto Challenges { get; set; }
    }
}
