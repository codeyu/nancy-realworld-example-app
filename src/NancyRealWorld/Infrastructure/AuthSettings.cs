using System;

namespace NancyRealWorld.Infrastructure
{
    internal class AuthSettings
    {
        public string SecretKeyBase64 { get; set; }

        public byte[] SecretKey
        {
            get
            {
                return Convert.FromBase64String(SecretKeyBase64);
            }
        }
    }
}