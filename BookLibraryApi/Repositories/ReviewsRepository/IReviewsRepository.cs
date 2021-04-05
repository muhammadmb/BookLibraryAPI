using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.ReviewsRepository
{
    public interface IReviewsRepository
    {
        Task<PagedList<Review>> GetReviews(Guid genreId, Guid bookId, ReviewResourcesParameters parameters);
        Task<Review> GetReview(Guid genreId, Guid bookId, Guid reviewId);
        void CreateReview(Review review);
        void UpdateReview(Review review);
        void Delete(Guid bookId, Guid reviewId);
        Task<bool> saveChangesAsync();
    }
}
