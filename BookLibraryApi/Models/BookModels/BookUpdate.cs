using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.BookModels
{
    public class BookUpdate
    {
        [Required]
        public string BookTitle { get; set; }

        [Url]
        public string BookCover { get; set; }

        public DateTimeOffset DateOfPublish { get; set; }

        public int NumberOfBookPages { get; set; }

        public string Publisher { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public Guid? AuthorId { get; set; }

        public Guid GenreId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
