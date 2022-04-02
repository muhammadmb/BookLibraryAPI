using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.AuthenticationModels
{
    public class TokenRequest
    {
        [Required]
        public string Token { get; set; }
        
        public string RefreshToken { get; set; }
    }
}
