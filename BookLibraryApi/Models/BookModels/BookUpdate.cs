using System;

namespace BookLibraryApi.Models.BookModels
{
    public class BookUpdate : GenericBookDto
    {
        public Guid? AuthorId { get; set; }

        public Guid GenreId { get; set; }
    }
}
