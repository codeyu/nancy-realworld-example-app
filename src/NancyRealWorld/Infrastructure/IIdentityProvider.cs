using System.Security.Claims;
using Nancy;

namespace NancyRealWorld.Infrastructure
{
    public interface IIdentityProvider
    {
         ClaimsPrincipal GetUserIdentity(NancyContext context);
    }
}