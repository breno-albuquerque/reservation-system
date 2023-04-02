using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.RegisterUser
{
    public class RegisterUserResponse
    {
        [JsonPropertyName("password")]
        public string Password { get; set; }

        public RegisterUserResponse(string password)
        {
            Password = password;
        }
    }
}
