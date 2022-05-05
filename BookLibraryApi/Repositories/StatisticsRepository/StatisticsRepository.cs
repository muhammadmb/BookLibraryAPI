using BookLibraryApi.Contexts;
using BookLibraryApi.Models.StatisticsModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.StatisticsRepository
{
    public class StatisticsRepository : IStatisticsRepository, IDisposable
    {
        private readonly BookContext _context;
        public StatisticsRepository(BookContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<Statistics> GetStatistics()
        {
            var books = await _context.Books.ToListAsync();
            var authors = await _context.Authors.ToListAsync();
            var reviews = await _context.Reviews.ToListAsync();
            var genres = await _context.Genres.ToListAsync();
            var feedback = await _context.Feedbacks.ToListAsync();
            var suggestions = await _context.Suggestions.ToListAsync();

            return new Statistics
            {
                Books = books.Count,
                Authors = authors.Count,
                Reviews = reviews.Count,
                Genres = genres.Count,
                Feedbacks = feedback.Count,
                Suggestions = suggestions.Count
            };
        }

        public async Task<List<BookStatistic>> GetBooksStatistics()
        {
            var books = await _context.Books
                .Where(b => b.AddedDate.Year == DateTime.Now.Year)
                .ToListAsync();

            var rt = books.GroupBy(b => b.AddedDate.Month)
                .Select(b => new BookStatistic
                {
                    Month = b.Key,
                    Books = b.Count()
                })
                .OrderBy(b => b.Month)
                .ToList();

            return new List<BookStatistic>(rt);
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
