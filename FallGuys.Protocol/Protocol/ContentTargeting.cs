using ProtoBuf;

namespace Catapult.Protocol
{
    [ProtoContract]
    public class ContentTargeting
    {
        public static ContentTargeting None => new ContentTargeting();

        [ProtoMember(1)]
        public string ContentVersion { get; set; }
        [ProtoMember(2)]
        public string ClientVersion { get; set; }
        [ProtoMember(3)]
        public string Platform { get; set; }
        [ProtoMember(4)]
        public string ContentETag { get; set; }
        [ProtoMember(5)]
        public string[] UserSegments { get; set; }
        public ContentTargeting(string contentVersion, string clientVersion, string platform, string contentETag,
            string[] userSegments)
        {
            ContentVersion = contentVersion;
            ClientVersion = clientVersion;
            Platform = platform;
            ContentETag = contentETag;
            UserSegments = userSegments;
        }

        public ContentTargeting()
        {
            
        }
    }
}
