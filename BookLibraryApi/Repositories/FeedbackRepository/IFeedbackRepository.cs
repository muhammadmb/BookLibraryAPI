using BookLibraryApi.Entities;
using BookLibraryApi.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.FeedbackRepository
{
    public interface IFeedbackRepository
    {
        Task<IEnumerable<Feedback>> GetFeedbacks(ResourcesParameters parameters);
        
        Task<Feedback> GetFeedback(Guid Id);

        void Create(Feedback feedback);

        void Update(Feedback feddback);
        
        void Delete(Guid id);

        Task<bool> SaveChangesAsync();
    }
}
