using BookLibraryApi.Models.AuthorsModels;
using BookLibraryApi.Models.GenreModels;
using BookLibraryApi.Models.RatingModels;
using System;

namespace BookLibraryApi.Models.BookModels
{
    public class BookDto
    {
        public Guid Id { get; set; }

        public string BookTitle { get; set; }

        public string BookCover { get; set; }

        public DateTimeOffset DateOfPublish { get; set; }

        public int NumberOfBookPages { get; set; }

        public RatingDto BookRating { get; set; }

        public string Publisher { get; set; }

        public string Description { get; set; }

        public AuthorForBook Author { get; set; }

        public GenreForOtherEntitiesDto Genre { get; set; }

        public DateTimeOffset AddedDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }
    }
}
