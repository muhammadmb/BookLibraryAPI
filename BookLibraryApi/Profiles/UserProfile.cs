using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.UserProfileModels;

namespace BookLibraryApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserProfileDto>();
            CreateMap<UserProfileUpdateDto, ApplicationUser>();
            CreateMap<ApplicationUser, UserProfileUpdateDto>();
        }
    }
}
