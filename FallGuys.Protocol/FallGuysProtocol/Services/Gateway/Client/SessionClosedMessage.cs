using ProtoBuf;

namespace Catapult.Services.Gateway.Client
{
    [ProtoContract]
    public class SessionClosedMessage
    {
        [ProtoMember(1)]
        public SessionClosedReason Reason { get; set; }
        [ProtoMember(2)]
        public int ConnectionClosingInSeconds { get; set; }
    }

    [ProtoContract]
    public enum SessionClosedReason
    {
        Unknown = 0,
        AnotherDeviceConnected = 1
    }
}
