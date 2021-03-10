using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.GenreModels;

namespace BookLibraryApi.Profiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreDto>();
            CreateMap<GenreCreation, Genre>();
            CreateMap<GenreUpdate, Genre>();
            CreateMap<Genre, GenreForAuthor>();
        }
    }
}
