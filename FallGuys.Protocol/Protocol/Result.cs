using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol.Internal;
using Catapult.Services.Gateway.Client;
using Catapult.Services.Gateway.Protocol.Client;
using ProtoBuf;

namespace Catapult.Protocol
{
    [ProtoContract]
    public class Result : Message, IContainStatusCode
    {
        [ProtoMember(1)]
        public ErrorDescription Error { get; set; }

        public bool IsSuccess => Error == null || Error.ErrorCode == (int)CatapultStatusCode.Ok;

        public Result()
        {

        }

        public Result(ErrorDescription error)
        {
            Error = error;
        }

        public static Result Ok()
        {
            return new Result();
        }

        public static Result<T> Ok<T>(T body)
        {
            return new Result<T>(body);
        }

        public static Result<T> Ok<T>(CatapultStatusCode statusCode, T body)
        {
            return new Result<T>(body) { Error = new ErrorDescription() { ErrorCode = Convert.ToUInt16(statusCode) } };
        }

        public static Result BadRequest(string message, Enum errorCode)
        {
            return Fail(CatapultStatusCode.BadRequest, message, errorCode);
        }

        public static Result Fail(CatapultStatusCode statusCode, string message, Enum errorCode,
            string technicalMessage = null)
        {
            return new Result(new ErrorDescription(statusCode, message, errorCode, technicalMessage));
        }

        public static Result Fail(ErrorMessage errorMessage)
        {
            return new Result(errorMessage.Error);
        }

        public TErrorCode GetErrorCode<TErrorCode>()
        {
            return (TErrorCode)Enum.Parse(typeof(TErrorCode), GetErrorCode().ToString());
        }
        public int GetErrorCode()
        {
            return Error?.ErrorCode ?? (ushort)CatapultStatusCode.Ok;
        }
    }

    [ProtoContract]
    public sealed class Result<TResultMessage> : Message, IContainStatusCode
    {
        [ProtoMember(1)]
        public TResultMessage Body { get; set; }
        [ProtoMember(2)]
        public ErrorDescription Error { get; set; }
        public bool IsSuccess => Error == null || Error.ErrorCode == (int)CatapultStatusCode.Ok;

        public Result(TResultMessage msg)
        {
            Body = msg;
        }

        public Result()
        {
            
        }

        public Result(ErrorDescription error)
        {
            Error = error;
        }

        public TErrorCode GetErrorCode<TErrorCode>()
        {
            return (TErrorCode) Enum.Parse(typeof(TErrorCode), GetErrorCode().ToString());
        }
        public int GetErrorCode()
        {
            return Error?.ErrorCode ?? (ushort)CatapultStatusCode.Ok;
        }

        public override string GetTypeName()
        {
            return $"Result<{typeof(TResultMessage).Name}>";
        }

        public bool IsErrorCode(Enum errorCode)
        {
            return (Error?.ErrorCode ?? (ushort)CatapultStatusCode.Ok) == Convert.ToUInt16(errorCode);
        }
        public bool IsErrorCode(uint errorCode)
        {
            return (Error?.ErrorCode ?? (ushort)CatapultStatusCode.Ok) == errorCode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (Error != null)
            {
                sb.AppendLine("Error:");
                sb.AppendLine(Error.ToString());
            }

            if (Body != null)
            {
                sb.AppendLine("Body:");
                sb.AppendLine(Body.ToString());
            }

            return sb.ToString();
        }

        public static implicit operator Result<TResultMessage>(Result result)
        {
            return new Result<TResultMessage>(result.Error);
        }
    }
}
