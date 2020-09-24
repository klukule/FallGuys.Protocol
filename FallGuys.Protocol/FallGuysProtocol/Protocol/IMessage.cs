using System;
using System.Collections.Generic;
using System.Text;

namespace Catapult.Protocol
{
    public interface IMessage
    {
        List<MessageHeader> Headers { get; }
    }
}
