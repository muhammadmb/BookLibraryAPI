using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.SuggesstionRepository
{
    public class SuggesstionRepository : ISuggesstionRepository, IDisposable
    {
        private readonly BookContext _context;

        public SuggesstionRepository(BookContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Suggesstion>> GetSuggesstions(ResourcesParameters parameters)
        {
            IQueryable<Suggesstion> Collection;

            Collection = _context.Suggesstions;

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                parameters.SearchQuery = parameters.SearchQuery.Trim();

                Collection = Collection.Where(s =>
                s.Email.Contains(parameters.SearchQuery) ||
                s.BookTitle.Contains(parameters.SearchQuery) ||
                s.Publisher.Contains(parameters.SearchQuery));
            }

            return await PagedList<Suggesstion>.Create(
                Collection,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public async Task<Suggesstion> GetSuggesstion(Guid id)
        {
            return await _context.Suggesstions.FirstOrDefaultAsync(s => s.Id == id);
        }

        public void Create(Suggesstion suggesstion)
        {
            _context.Suggesstions.Add(suggesstion);
        }

        public void Update(Suggesstion suggesstion)
        {
            _context.Suggesstions.Update(suggesstion);
        }

        public void Delete(Guid id)
        {
            var suggesstion = new Suggesstion()
            {
                Id = id
            };
            _context.Suggesstions.Remove(suggesstion);
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
