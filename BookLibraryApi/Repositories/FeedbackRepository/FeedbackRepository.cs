using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.FeedbackRepository
{
    public class FeedbackRepository : IFeedbackRepository, IDisposable
    {
        private readonly BookContext _context;

        public FeedbackRepository(BookContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<PagedList<Feedback>> GetFeedbacks(ResourcesParameters parameters)
        {
            IQueryable<Feedback> Collection;

            Collection = _context.Feedbacks.OrderByDescending(f => f.AddedDate);

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                parameters.SearchQuery = parameters.SearchQuery.Trim();

                Collection =
                    Collection.Where(f =>
                    f.Description.Contains(parameters.SearchQuery) ||
                    f.Email.Contains(parameters.SearchQuery));
            }

            return await PagedList<Feedback>.Create(
                Collection,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public async Task<Feedback> GetFeedback(Guid Id)
        {
            return await _context.Feedbacks.FirstOrDefaultAsync(f => f.Id == Id);
        }

        public void Create(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);
        }

        public void Update(Feedback feddback)
        {
            feddback.UpdateDate = DateTimeOffset.Now;
            _context.Feedbacks.Update(feddback);
        }

        public void Delete(Guid id)
        {
            var feedback = _context.Feedbacks.FirstOrDefault(f => f.Id == id);
            feedback.IsDeleted = DateTimeOffset.Now;
            _context.Feedbacks.Update(feedback);
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
