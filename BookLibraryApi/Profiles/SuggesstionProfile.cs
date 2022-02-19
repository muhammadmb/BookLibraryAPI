using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.SuggesstionModels;

namespace BookLibraryApi.Profiles
{
    public class SuggesstionProfile : Profile
    {
        public SuggesstionProfile()
        {
            CreateMap<SuggesstionCreationDto, Suggesstion>();
            CreateMap<SuggesstionUpdateDto, Suggesstion>();
            CreateMap<Suggesstion, SuggesstionUpdateDto>();
        }
    }
}
