using System;

namespace Catapult.Protocol
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class AuthorizeAttribute: Attribute
    {
        public bool AllowAnonymous { get; set; }
        public string[] Roles { get; set; }
    }
}
