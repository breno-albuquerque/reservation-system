using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels
{
    public abstract class ResponseBase
    {
        [JsonPropertyName("errors")]
        public IEnumerable<string> Errors { get; set; } = Enumerable.Empty<string>();

        [JsonConstructor]
        public ResponseBase(IEnumerable<string> errors)
        {
            Errors = errors;
        }
    }
}
