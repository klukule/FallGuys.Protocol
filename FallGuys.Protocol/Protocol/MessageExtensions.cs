using System.Text;
using Catapult.Protocol.Headers;

namespace Catapult.Protocol
{
    public static class MessageExtensions
    {
        public static string GetRequestId(this Message message)
        { 
            return message.GetHeader<OperationHeader>()?.RequestId.ToString() ?? "";
        }
        public static string GetCorrelationId(this Message message)
        {
            return message.GetHeader<CorrelationHeader>()?.ActivityId.ToString() ?? "";
        }
        public static string GetUserId(this Message message)
        {
            return message.GetHeader<UserSessionHeader>()?.UserId ?? "";
        }
    }
}
