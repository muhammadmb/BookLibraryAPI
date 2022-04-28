using BookLibraryApi.Models.UserProfileModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<List<UserProfileDto>> GetUsers();
        Task<List<string>> GetUserRoles(UserProfileDto user);
    }
}
