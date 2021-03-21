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
    public class ReviewsRepository : IReviewsRepository
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
                if (parameters.OrderBy.ToLowerInvariant() == "UpVote")
                {
                    Collection =
                        Collection.OrderBy(r => r.UpVote);
                }
                if (parameters.OrderBy.ToLowerInvariant() == "DownVote")
                {
                    Collection =
                        Collection.OrderBy(r => r.DownVote);
                }
            }

            return PagedList<Review>.Create(
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
            _context.Reviews.Update(review);
        }
        public async Task<bool> saveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }
    }
}
