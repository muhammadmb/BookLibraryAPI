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

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfDeath { get; set; }

        public GenreForOtherEntitiesDto Genre { get; set; }
    }
}
