using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.RatingModels;

namespace BookLibraryApi.Profiles
{
    public class RatingProfile : Profile
    {
        public RatingProfile()
        {
            CreateMap<BookRating, RatingDto>();
        }
    }
}
