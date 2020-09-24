using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol.Internal
{
    [ProtoContract]
    public class ErrorDescription
    {
        [ProtoMember(1)]
        public ushort ErrorCode { get; set; }
        [ProtoMember(2)]
        public string ErrorString { get; set; }
        [ProtoMember(3)]
        public string Message { get; set; }
        [ProtoMember(4)]
        public ErrorDetails Details { get; set; }

        public ErrorDescription()
        {
            ErrorCode = 0;
            Message = null;
        }

        public ErrorDescription(CatapultStatusCode statusCode, string message, Enum serverCode, string technicalMessage = null)
        {
            Details = new ErrorDetails
            {
                ServerCode = Convert.ToInt32(serverCode),
                Reason = serverCode.ToString(),
                TechnicalMessage = technicalMessage
            };

            ErrorCode = Convert.ToUInt16(statusCode);
            ErrorString = statusCode.ToString();
            Message = message;
        }

        [ProtoBeforeSerialization]
        public void BeforeSerialize(SerializationContext context)
        {
            if (context.Context != null && context.Context is CatapultSerializationContext csc)
            {
                if (csc.OmitErrorDetails)
                    Details = null;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"ErrorCode: {ErrorCode}");
            sb.AppendLine($"ErrorString: {ErrorString}");
            sb.AppendLine($"Message: {Message}");

            if (Details != null)
                sb.AppendLine(Details.ToString());
            
            return sb.ToString();
        }
    }
}
