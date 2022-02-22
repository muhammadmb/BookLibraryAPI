using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.SuggesstionRepository
{
    public interface ISuggesstionRepository
    {
        Task<PagedList<Suggesstion>> GetSuggesstions(ResourcesParameters parameters);

        Task<Suggesstion> GetSuggesstion(Guid id);

        void Create(Suggesstion suggesstion);

        void Update(Suggesstion suggesstion);

        void Delete(Guid id);

        Task<bool> SaveChangesAsync();

    }
}
