using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol
{
    [ProtoContract]
    public class DateTimeOffsetSurrogate
    {
        [ProtoMember(1)]
        public string DateTimeOffsetString { get; set; }

        public static implicit operator DateTimeOffsetSurrogate(DateTimeOffset source)
        {
            return new DateTimeOffsetSurrogate() { DateTimeOffsetString = source.ToString() };
        }

        public static implicit operator DateTimeOffset(DateTimeOffsetSurrogate source)
        {
            return string.IsNullOrEmpty(source.DateTimeOffsetString) ? default : DateTimeOffset.Parse(source.DateTimeOffsetString, null, DateTimeStyles.RoundtripKind);
        }
    }
}
