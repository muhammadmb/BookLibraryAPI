using BookLibraryApi.Contexts;
using BookLibraryApi.Models.AuthenticationModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.AuthenticationRepository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly BookContext _context;
        public AuthenticationRepository(BookContext context)
        {
            _context = context ??
               throw new ArgumentNullException(nameof(context));
        }
        public void AddRefreshToken(RefreshTokens refreshTokens)
        {
            _context.RefreshTokens.AddAsync(refreshTokens);
        }

        public void Update(RefreshTokens storedToken)
        {
            _context.RefreshTokens.Update(storedToken);
        }

        public async Task<RefreshTokens> getRefreshToken(TokenRequest tokenRequest)
        {
            return await _context.RefreshTokens.FirstOrDefaultAsync(x => x.Token == tokenRequest.RefreshToken);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }       
    }
}
