﻿using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.AuthorsModels;

namespace BookLibraryApi.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorForBook>();
            CreateMap<Author, AuthorDto>();
            CreateMap<AuthorCreation, Author>();
            CreateMap<UpdateAuthor, Author>();
            CreateMap<Author, UpdateAuthor>();
        }
    }
}
