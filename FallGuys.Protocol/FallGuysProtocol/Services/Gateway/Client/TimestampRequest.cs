using System;
using System.Collections.Generic;
using System.Text;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Gateway.Client
{
    [Authorize(AllowAnonymous = true)]
    [ProtoContract]
    public class TimestampRequest
    {
    }
}
