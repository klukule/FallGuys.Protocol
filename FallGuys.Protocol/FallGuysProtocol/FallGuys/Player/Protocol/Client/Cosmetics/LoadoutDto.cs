using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics
{

    [ProtoContract]
    public class LoadoutDto
    {
        [ProtoMember(1)]
        public UpperCostumePieceDto Upper { get; set; }
        [ProtoMember(2)]
        public LowerCostumePieceDto Lower { get; set; }
        [ProtoMember(3)]
        public FaceplateDto Faceplate { get; set; }
        [ProtoMember(4)]
        public ColourSchemeDto ColourScheme { get; set; }
        [ProtoMember(5)]
        public PatternDto Pattern { get; set; }
        [ProtoMember(6)]
        public PunchlineDto Punchline { get; set; }
        [ProtoMember(7)]
        public MonolithicCostumeDto MonolithicCostume { get; set; }
        [ProtoMember(8)]
        public Dictionary<int, EmoteDto> Emotes { get; set; }
        [ProtoMember(9)]
        public NameplateDto Nameplate { get; set; }
        [ProtoMember(10)]
        public NicknameDto Nickname { get; set; }
        [ProtoMember(11)]
        public PlinthDto Plinth { get; set; }
    }
}
