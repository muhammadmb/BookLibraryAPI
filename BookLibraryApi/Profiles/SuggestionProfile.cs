using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.SuggesstionModels;

namespace BookLibraryApi.Profiles
{
    public class SuggestionProfile : Profile
    {
        public SuggestionProfile()
        {
            CreateMap<SuggestionCreationDto, Suggestion>();
            CreateMap<SuggestionUpdateDto, Suggestion>();
            CreateMap<Suggestion, SuggestionUpdateDto>();
        }
    }
}
