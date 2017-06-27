using System;
using System.Collections.Generic;
using System.Security.Principal;
namespace NancyRealWorld.Infrastructure
{
    public class UserIdentity : IIdentity
    {
        public string AuthenticationType => "";

        public bool IsAuthenticated { get; }

        public string Name {get;}

        public UserIdentity(string name)
        {
            Name = name;
            IsAuthenticated = true;
        }
    }
}