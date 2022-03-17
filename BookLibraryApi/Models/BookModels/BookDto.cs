using BookLibraryApi.Models.AuthorsModels;
using BookLibraryApi.Models.GenreModels;
using BookLibraryApi.Models.RatingModels;
using System;

namespace BookLibraryApi.Models.BookModels
{
    public class BookDto : GenericBookDto
    {
        public Guid Id { get; set; }

        public RatingDto BookRating { get; set; }

        public AuthorForBook Author { get; set; }

        public GenreForOtherEntitiesDto Genre { get; set; }

        public DateTimeOffset AddedDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }
    }
}
