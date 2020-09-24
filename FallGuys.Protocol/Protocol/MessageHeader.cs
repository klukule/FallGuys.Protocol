using Catapult.Protocol.Headers;
using ProtoBuf;

namespace Catapult.Protocol
{
    [ProtoContract]
    // TODO: Get dynamically from ClientGeneratedProtoSerializer_Read
    [ProtoInclude(2056396, typeof(UserSessionHeader))]
    [ProtoInclude(31685340, typeof(CorrelationHeader))]
    [ProtoInclude(51110556, typeof(OperationHeader))]
    [ProtoInclude(60349934, typeof(TraceHeader))]
    [ProtoInclude(72409651, typeof(TimeModifierHeader))]
    [ProtoInclude(89108981, typeof(TimestampHeader))]
    public class MessageHeader : IMessageHeader
    {
        public MessageHeader()
        {
        }
    }
}
