using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol.Internal
{
    [ProtoContract]
    public class ErrorMessage : Message, IContainStatusCode
    {
        [Obsolete]
        [ProtoIgnore]
        public ushort ErrorCode { get; set; }
        [Obsolete]
        [ProtoIgnore]
        public string ErrorString { get; set; }
        [ProtoMember(1)]
        public ErrorDescription Error { get; set; }

        [ProtoIgnore] public bool IsSuccess => GetErrorCode() == (int)CatapultStatusCode.Ok; // TODO: Verify

        public ErrorMessage()
        {
            Error = new ErrorDescription {ErrorCode = 0, Message = null};
        }

        public ErrorMessage(ErrorDescription error)
        {
            Error = error;
        }

        public int GetErrorCode() => Error?.ErrorCode ?? 0;
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(GetTypeName());

            if (Error != null)
            {
                sb.AppendLine("Error:");
                sb.AppendLine(Error.ToString());
            }

            return sb.ToString();
        }
    }
}
