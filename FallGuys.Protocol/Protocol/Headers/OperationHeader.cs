using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol.Headers
{
    public enum OperationType
    {
        OneWay = 1,
        Request = 2,
        Reply = 3
    }

    [ProtoContract]
    public class OperationHeader : MessageHeader
    {
        [ProtoMember(1)]
        public Guid RequestId { get; set; }
        [ProtoMember(2)]
        public OperationType Type { get; set; }

        public OperationHeader()
        {
            
        }

        public OperationHeader(Guid requestId, OperationType type)
        {
            RequestId = requestId;
            Type = type;
        }

        public override string ToString()
        {
            return $"OperationHeader<RequestId:{RequestId}, Type:{Type}>";
        }
    }
}
