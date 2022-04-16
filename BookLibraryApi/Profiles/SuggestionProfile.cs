using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.SuggesstionModels;

namespace BookLibraryApi.Profiles
{
    public class SuggestionProfile : Profile
    {
        public SuggestionProfile()
        {
            CreateMap<Suggestion, SuggestionDto>();
            CreateMap<SuggestionCreationDto, Suggestion>();
            CreateMap<SuggestionUpdateDto, Suggestion>().ReverseMap();
        }
    }
}
