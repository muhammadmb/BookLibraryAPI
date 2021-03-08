using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.ReviewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Profiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewForBook>();
        }
    }
}
