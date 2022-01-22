using BookLibraryApi.Models.AuthenticationModels;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.AuthenticationRepository
{
    public interface IAuthenticationRepository
    {
        void AddRefreshToken(RefreshTokens refreshTokens);
        void Update(RefreshTokens storedToken);
        Task<RefreshTokens> getRefreshToken(TokenRequest tokenRequest);
        Task<bool> SaveChangesAsync();
        
    }
}
