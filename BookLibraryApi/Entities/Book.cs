using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

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

        public BookRating BookRating { get; set; }

        public Guid AuthorId { get; set; }

        public Author Author { get; set; }

        public List<Review> Reviews { get; set; }

        public Guid GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
