using BookLibraryApi.Models.GenreModels;
using System;

namespace BookLibraryApi.Models.AuthorsModels
{
    public class AuthorDto : GenericAuthorDto
    {
        public Guid Id { get; set; }

        public GenreForOtherEntitiesDto Genre { get; set; }

        public DateTimeOffset AddedDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }
    }
}
