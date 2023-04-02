using RerservationSystem.Core.Shared.Roles.Enums;
using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.RegisterUser
{
    public class RegisterUserRequest
    {
        [JsonPropertyName("document")]
        public string? Document { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("userRole")]
        public ERole Role { get; set; }
    }
}
