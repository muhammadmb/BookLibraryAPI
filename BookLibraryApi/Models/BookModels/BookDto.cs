using BookLibraryApi.Models.AuthorsModels;
using BookLibraryApi.Models.GenreModels;
using BookLibraryApi.Models.RatingModels;
using BookLibraryApi.Models.ReviewModels;
using System;
using System.Collections.Generic;

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

        public List<ReviewForBook> Reviews { get; set; }

        public GenreDto Genre { get; set; }

    }
}
