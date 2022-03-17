using System;

namespace BookLibraryApi.Models.BookModels
{
    public class BookCreation : GenericBookDto
    {
        public Guid AuthorId { get; set; }
    }
}
