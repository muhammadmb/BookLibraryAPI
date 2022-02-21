using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.AuthorRepository
{
    public class AuthorRepository : IAuthorRepository, IDisposable
    {
        private readonly BookContext _context;

        public AuthorRepository(BookContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<PagedList<Author>> GetAuthors(AuthorResourcesParameters parameters)
        {
            IQueryable<Author> Collection;

            Collection =
                _context.Authors
                .Include(a => a.Genre)
                .Include(a => a.Books);

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                parameters.SearchQuery = parameters.SearchQuery.Trim();

                Collection =
                    Collection.Where(a => a.Name.Contains(parameters.SearchQuery));
            }

            return
                await PagedList<Author>.Create(
                    Collection,
                    parameters.PageNumber,
                    parameters.PageSize
                );
        }

        public async Task<Author> GetAuthor(Guid id)
        {
            return await _context.Authors
                .Include(a => a.Genre)
                .Include(a => a.Books)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public void CreateAuthor(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Update(Author authorFromRepo)
        {
            authorFromRepo.UpdateDate = DateTimeOffset.Now;
            _context.Authors.Update(authorFromRepo);
        }

        public void Delete(Guid id)
        {
            var author = _context.Authors.FirstOrDefault(a => a.Id == id);
            author.IsDeleted = DateTimeOffset.Now;
            _context.Authors.Update(author);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }
}
