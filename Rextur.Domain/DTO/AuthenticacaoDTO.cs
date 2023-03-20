using System.Text.Json.Serialization;

namespace Rextur.Domain.DTO
{
    public class AuthenticacaoDTO
    {
        public AuthenticacaoDTO(string username,string password)
        {
            this.Username = username;
            this.Password = password;
        }

        [JsonPropertyName("username")]
        public string Username { get; private set; }
        [JsonPropertyName("password")]  
        public string Password { get; private set; }
    }
}
