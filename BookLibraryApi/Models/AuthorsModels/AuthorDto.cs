using BookLibraryApi.Entities;
using BookLibraryApi.Models.BookModels;
using BookLibraryApi.Models.GenreModels;
using System;
using System.Collections.Generic;

namespace BookLibraryApi.Models.AuthorsModels
{
    public class AuthorDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public string Bio { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public DateTimeOffset DateOfDeath { get; set; }

        public List<BookForAuthor> Books { get; set; }

        public GenreForAuthor Genre { get; set; }
    }
}
