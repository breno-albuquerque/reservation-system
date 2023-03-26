using RerservationSystem.Core.Shared.Users.Entities;
using System.Security.Claims;

namespace RerservationSystem.Core.Shared.Services.JwtToken
{
    public interface ITokenService
    {
        string GenerateToken(User user);

        IEnumerable<Claim> GetClaims(User user);
    }
}
