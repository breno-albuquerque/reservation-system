using Microsoft.IdentityModel.Tokens;
using RerservationSystem.Core.Shared.Users.Entities;
using ReservationSystem.WebApi.Configurations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ReservationSystem.WebApi.Services
{
    public class TokenService
    {
        public string GenerateToken(User user)
        {
            var handler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(JwtConfiguration.Key);

            var descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(GetClaims(user)),

                Expires = DateTime.UtcNow.AddHours(8),

                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = handler.CreateToken(descriptor);

            return handler.WriteToken(token);
        }

        public IEnumerable<Claim> GetClaims(User user)
        {
            return new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.UserRole.RoleName),
            };
        }
    }
}
