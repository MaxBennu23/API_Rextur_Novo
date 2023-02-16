using System.Text.Json.Serialization;

namespace Rextur.Domain.DTO
{
    public class AuthenticacaoDTO
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("password")]  
        public string Password { get; set; }
    }
}
