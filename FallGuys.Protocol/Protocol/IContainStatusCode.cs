using System;
using System.Collections.Generic;
using System.Text;

namespace Catapult.Protocol
{
    public interface IContainStatusCode
    {
        bool IsSuccess { get; }
        int GetErrorCode();
    }
}
