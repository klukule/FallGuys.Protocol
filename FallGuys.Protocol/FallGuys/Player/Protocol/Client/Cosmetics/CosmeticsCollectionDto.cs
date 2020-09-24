using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics
{
    [ProtoContract]
    public class CosmeticsCollectionDto
    {
        [ProtoMember(1)]
        public List<LowerCostumePieceDto> LowerCostumePieces { get; set; }
        [ProtoMember(2)]
        public List<UpperCostumePieceDto> UpperCostumePieces { get; set; }
        [ProtoMember(3)]
        public List<FaceplateDto> Faceplates { get; set; }
        [ProtoMember(4)]
        public List<ColourSchemeDto> ColourSchemes { get; set; }
        [ProtoMember(5)]
        public List<PatternDto> Patterns { get; set; }
        [ProtoMember(6)]
        public List<EmoteDto> Emotes { get; set; }
        [ProtoMember(7)]
        public List<PunchlineDto> Punchlines { get; set; }
        [ProtoMember(8)]
        public List<MonolithicCostumeDto> MonolithicCostumes { get; set; }
        [ProtoMember(9)]
        public List<NameplateDto> Nameplates { get; set; }
        [ProtoMember(10)]
        public List<NicknameDto> Nicknames { get; set; }
        [ProtoMember(11)]
        public List<PlinthDto> Plinths { get; set; }
    }
}
