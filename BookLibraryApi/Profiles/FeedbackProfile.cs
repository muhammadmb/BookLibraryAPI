using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.FeedbackModels;

namespace BookLibraryApi.Profiles
{
    public class FeedbackProfile : Profile
    {
        public FeedbackProfile()
        {
            CreateMap<FeedbackCreationDto, Feedback>();
            CreateMap<FeedbackUpdateDto, Feedback>();
            CreateMap<Feedback, FeedbackUpdateDto>();
        }
    }
}
