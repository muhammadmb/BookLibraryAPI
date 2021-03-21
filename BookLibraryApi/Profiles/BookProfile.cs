using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.BookModels;

namespace BookLibraryApi.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookUpdate, Book>();
            CreateMap<Book, BookUpdate>();
            CreateMap<BookCreation, Book>();
            CreateMap<Book, BookForAuthor>();
        }
    }
}