﻿using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.FeedbackRepository
{
    public interface IFeedbackRepository
    {
        Task<PagedList<Feedback>> GetFeedbacks(ResourcesParameters parameters);

        Task<Feedback> GetFeedback(Guid Id);

        void Create(Feedback feedback);

        void Update(Feedback feddback);

        void Delete(Guid id);

        Task<bool> SaveChangesAsync();
    }
}
