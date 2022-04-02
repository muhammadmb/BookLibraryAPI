using System.Collections.Generic;

namespace BookLibraryApi.Configuration
{
    public class AuthResult
    {
        public string Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<string> Roles { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
