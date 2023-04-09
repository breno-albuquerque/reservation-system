using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.LoginUser
{
    public sealed class LoginUserRequest
    {
        [JsonPropertyName("email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email must be valid")]
        public string? Email { get; set; }

        [JsonPropertyName("password")]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
