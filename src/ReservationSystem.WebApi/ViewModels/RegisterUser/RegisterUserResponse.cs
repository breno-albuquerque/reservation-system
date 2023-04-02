using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.RegisterUser
{
    public class RegisterUserResponse
    {
        [JsonPropertyName("jwtToken")]
        public string JwtToken { get; set; }

        public RegisterUserResponse(string jwtToken)
        {
            JwtToken = jwtToken;
        }
    }
}
