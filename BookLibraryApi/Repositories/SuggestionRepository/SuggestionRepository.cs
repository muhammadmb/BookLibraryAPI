using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.SuggesstionRepository
{
    public class SuggestionRepository : ISuggestionRepository, IDisposable
    {
        private readonly BookContext _context;

        public SuggestionRepository(BookContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<PagedList<Suggestion>> GetSuggestions(ResourcesParameters parameters)
        {
            IQueryable<Suggestion> Collection;

            Collection = _context.Suggestions.Include(s => s.Genre ).Include(s => s.Author);

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                parameters.SearchQuery = parameters.SearchQuery.Trim();

                Collection = Collection.Where(s =>
                s.Email.Contains(parameters.SearchQuery) ||
                s.BookTitle.Contains(parameters.SearchQuery) ||
                s.Publisher.Contains(parameters.SearchQuery));
            }

            return await PagedList<Suggestion>.Create(
                Collection,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public async Task<Suggestion> GetSuggesstion(Guid id)
        {
            return await _context.Suggestions.FirstOrDefaultAsync(s => s.Id == id);
        }

        public void Create(Suggestion suggesstion)
        {
            _context.Suggestions.Add(suggesstion);
        }

        public void Update(Suggestion suggesstion)
        {
            suggesstion.UpdateDate = DateTimeOffset.Now;
            _context.Suggestions.Update(suggesstion);
        }

        public void Delete(Guid id)
        {
            var suggestion = _context.Suggestions.FirstOrDefault(s => s.Id == id);
            suggestion.IsDeleted = DateTimeOffset.Now;
            _context.Suggestions.Update(suggestion);
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
