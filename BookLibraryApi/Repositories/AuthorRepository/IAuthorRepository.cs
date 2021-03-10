using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.AuthorRepository
{
    public interface IAuthorRepository
    {
        Task<PagedList<Author>> GetAuthors(AuthorResourcesParameters parameters);
        Task<Author> GetAuthor(Guid id);
        void CreateAuthor(Author author);
        void Update(Author authorFromRepo);
        Task<bool> SaveChangesAsync();
    }
}
