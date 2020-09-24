using ProtoBuf;

namespace Catapult.Services.Gateway.Client
{
    [ProtoContract]
    public class ContentUpdateNotification
    {
        [ProtoMember(1)]
        public string ContentUrl { get; set; }
        [ProtoMember(2)]
        public string ContentVersion { get; set; }
        [ProtoMember(3)]
        public string ForceClientUpgrade { get; set; }
    }
}
