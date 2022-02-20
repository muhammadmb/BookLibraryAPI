using BookLibraryApi.Models.GenreModels;
using System;

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

        public GenreForOtherEntitiesDto Genre { get; set; }
    }
}
