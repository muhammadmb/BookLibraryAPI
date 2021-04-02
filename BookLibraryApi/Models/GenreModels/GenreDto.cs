using BookLibraryApi.Entities;
using BookLibraryApi.Models.BookModels;
using System;
using System.Collections.Generic;

namespace BookLibraryApi.Models.GenreModels
{
    public class GenreDto
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string GenreName { get; set; }

        public List<BookForGenre> Books { get; set; }

        public string PicUrl { get; set; }
    }
}
