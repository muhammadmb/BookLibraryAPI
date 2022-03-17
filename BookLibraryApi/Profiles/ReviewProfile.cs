using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.ReviewModels;

namespace BookLibraryApi.Profiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewCreation, Review>();
            CreateMap<ReviewUpdate, Review>();
            CreateMap<Review, ReviewUpdate>();
        }
    }
}
