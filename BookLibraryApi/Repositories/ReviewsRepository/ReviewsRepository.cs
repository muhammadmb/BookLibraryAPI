using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.ReviewsRepository
{
    public class ReviewsRepository : IReviewsRepository, IDisposable
    {
        private readonly BookContext _context;

        public ReviewsRepository(BookContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<PagedList<Review>> GetReviews(Guid genreId, Guid bookId, ReviewResourcesParameters parameters)
        {
            var Collection =
                _context.Reviews
                .Where(r => r.BookId == bookId && r.Book.GenreId == genreId)
                as IQueryable<Review>;

            if (!string.IsNullOrWhiteSpace(parameters.OrderBy))
            {
                parameters.OrderBy = parameters.OrderBy.Trim();
                if (parameters.OrderBy.ToLowerInvariant() == "upvote")
                {
                    Collection =
                        Collection.OrderByDescending(r => r.UpVote);
                }
                if (parameters.OrderBy.ToLowerInvariant() == "downvote")
                {
                    Collection =
                        Collection.OrderByDescending(r => r.DownVote);
                }
                if (parameters.OrderBy.ToLowerInvariant() == "addeddate")
                {
                    Collection =
                        Collection.OrderByDescending(r => r.AddedDate);
                }
            }

            return await PagedList<Review>.Create(
                Collection,
                parameters.PageNumber,
                parameters.PageSize);
        }
        public async Task<Review> GetReview(Guid genreId, Guid bookId, Guid reviewId)
        {
            return await _context.Reviews
                .FirstOrDefaultAsync(r => r.Id == reviewId && r.BookId == bookId && r.Book.GenreId == genreId);
        }

        public void CreateReview(Review review)
        {
            review.handelRatting(_context);
            _context.Reviews.Add(review);
        }
        public void UpdateReview(Review review)
        {
            review.UpdateDate = DateTimeOffset.Now;
            _context.Reviews.Update(review);
        }

        public void Delete(Guid bookId, Guid reviewId)
        {
            var review = _context.Reviews.FirstOrDefault(r => r.Id == reviewId && r.BookId == bookId);
            review.IsDeleted = DateTimeOffset.Now;
            _context.Reviews.Update(review);
        }

        public async Task<bool> saveChangesAsync()
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
