using System;
using System.Security.Claims;
using Jose;
using Nancy;

namespace NancyRealWorld.Infrastructure
{
    internal sealed class IdentityProvider : IIdentityProvider
    {
        private readonly AuthSettings _authSettings;
        private const string _bearerDeclaration = "Bearer ";

        public IdentityProvider(AuthSettings authSettings)
        {
            _authSettings = authSettings;
        }

        public ClaimsPrincipal GetUserIdentity(NancyContext context)
        {
            try
            {
                var authorizationHeader = context.Request.Headers.Authorization;
                var jwt = authorizationHeader.Substring(0, _bearerDeclaration.Length);
                var payload = Jose.JWT.Decode<JwtToken>(jwt, _authSettings.SecretKey, JwsAlgorithm.HS256);

                var tokenExpires = DateTime.FromBinary(payload.exp);

                if (tokenExpires > DateTime.UtcNow)
                {
                    return new ClaimsPrincipal(new UserIdentity(payload.sub));
                }

                return null;


            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}