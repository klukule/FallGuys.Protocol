using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics
{

    [Authorize(Roles = new[] { "User" })]
    [ProtoContract]
    public class ConfigureLoadoutCommand
    {
        [ProtoMember(1)]
        public string UpperPieceId { get; set; }
        [ProtoMember(2)]
        public string LowerPieceId { get; set; }
        [ProtoMember(3)]
        public string FaceplateId { get; set; }
        [ProtoMember(4)]
        public string ColourSchemeId { get; set; }
        [ProtoMember(5)]
        public string PatternId { get; set; }
        [ProtoMember(6)]
        public string PunchlineId { get; set; }
        [ProtoMember(7)]
        public string MonolithicCostumeId { get; set; }
        [ProtoMember(8)]
        public string NameplateId { get; set; }
        [ProtoMember(9)]
        public string NicknameId { get; set; }
        [ProtoMember(10)]
        public string PlinthId { get; set; }
    }
}
