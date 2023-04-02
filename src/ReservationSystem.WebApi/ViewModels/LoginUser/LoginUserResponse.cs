using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.LoginUser
{
    public class LoginUserResponse : ResponseBase
    {
        [JsonPropertyName("jwtToken")]
        public string? JwtToken { get; set; }

        public LoginUserResponse(string? jwtToken, IEnumerable<string> errors)
            : base(errors)
        {
            JwtToken = jwtToken;
        }
    }
}
