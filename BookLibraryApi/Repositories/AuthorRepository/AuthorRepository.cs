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
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookContext _context;

        public AuthorRepository(BookContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }


        public async Task<PagedList<Author>> GetAuthors(AuthorResourcesParameters parameters)
        {
            var Collection =
                _context.Authors
                .Include(a => a.Genre)
                .Include(a => a.Books)
                as IQueryable<Author>;

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                parameters.SearchQuery = parameters.SearchQuery.Trim();

                Collection =
                    Collection.Where(a => a.Name.Contains(parameters.SearchQuery));
            }

            return
                PagedList<Author>.Create(
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
            _context.Authors.Update(authorFromRepo);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }
    }
}
