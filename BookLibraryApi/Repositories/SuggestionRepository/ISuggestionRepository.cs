using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.SuggesstionRepository
{
    public interface ISuggestionRepository
    {
        Task<PagedList<Suggestion>> GetSuggestions(ResourcesParameters parameters);

        Task<Suggestion> GetSuggesstion(Guid id);

        void Create(Suggestion suggesstion);

        void Update(Suggestion suggesstion);

        void Delete(Guid id);

        Task<bool> SaveChangesAsync();

    }
}
