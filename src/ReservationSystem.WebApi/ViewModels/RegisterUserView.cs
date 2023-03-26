using RerservationSystem.Core.Shared.Roles.Enums;
using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.Transport
{
    public class RegisterUserView
    {
        [JsonPropertyName("document")]
        public string Document { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("userRole")]
        public ERole Role { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
