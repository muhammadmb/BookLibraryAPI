using BookLibraryApi.Models.AuthorsModels;
using System;

namespace BookLibraryApi.Models.BookModels
{
    public class BookForOtherEntities
    {
        public Guid Id { get; set; }

        public string BookTitle { get; set; }

        public string BookCover { get; set; }

        public Guid GenreId { get; set; }

        public AuthorForBook Author { get; set; }
    }
}
