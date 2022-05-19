using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.UserProfileModels;

namespace BookLibraryApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserProfileDto>().ForMember(
                dest => dest.Gender,
                opt => opt.MapFrom(src => src.Gender == 0 ? "Male" : "Female"));
            CreateMap<UserProfileUpdateDto, ApplicationUser>();
            CreateMap<ApplicationUser, UserProfileUpdateDto>();
        }
    }
}
