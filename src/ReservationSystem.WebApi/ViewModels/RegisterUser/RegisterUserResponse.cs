using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.RegisterUser
{
    public class RegisterUserResponse : ResponseBase
    {
        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonConstructor]
        public RegisterUserResponse(string? password, IEnumerable<string> errors)
            : base(errors)
        {
            Password = password;
        }
    }
}
