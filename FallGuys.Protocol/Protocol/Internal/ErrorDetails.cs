using System;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol.Internal
{
    [ProtoContract]
    public class ErrorDetails
    {
        [ProtoMember(1)]
        public int ServerCode { get; set; }
        [ProtoMember(2)]
        public string Reason { get; set; }
        [ProtoMember(3)]
        public string TechnicalMessage { get; set; }
        [ProtoMember(4)]
        public ErrorDescription Inner { get; set; }

        public ErrorDetails()
        {
            
        }

        public ErrorDetails(Enum errorCode, string technicalMessage = null)
        {
            TechnicalMessage = technicalMessage;
            ServerCode = Convert.ToInt32(errorCode);
            Reason = errorCode.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"ServerCode: {ServerCode}");
            sb.AppendLine($"Reason: {Reason}");
            sb.AppendLine($"TechnicalMessage: {TechnicalMessage}");

            if (Inner != null)
            {
                sb.AppendLine();
                sb.AppendLine("Inner:");
                sb.AppendLine(Inner.ToString());
            }

            return sb.ToString();
        }
    }
}
