using RerservationSystem.Core.Shared.Roles.Enums;
using ReservationSystem.WebApi.Attributes.DataType;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.RegisterUser
{
    public sealed class RegisterUserRequest
    {
        [JsonPropertyName("document")]
        [Required(ErrorMessage = "Document is required")]
        [Cpf(ErrorMessage = "Document must be valid")]
        public string Document { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email must be valid")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("userRole")]
        [Required(ErrorMessage = "User Role is required")]
        [Role(ErrorMessage = "User Role must be in valid")]
        public ERole Role { get; set; }
    }
}
