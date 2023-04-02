using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.LoginUser
{
    public class LoginUserResponse
    {
        [JsonPropertyName("jwtToken")]
        public string JwtToken { get; set; }

        public LoginUserResponse(string jwtToken)
        {
            JwtToken = jwtToken;
        }
    }
}
