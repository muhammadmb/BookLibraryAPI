using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class Suggestion
    {
        [Key]
        public Guid Id { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Url]
        public string BookCover { get; set; }

        public DateTime DateOfPublish { get; set; }

        public DateTimeOffset AddedDate { get; set; } = DateTimeOffset.Now;

        public int NumberOfBookPages { get; set; }

        public string Publisher { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public Guid? AuthorId { get; set; }

        public Author? Author { get; set; }

        public Guid? GenreId { get; set; }

        public Genre? Genre { get; set; }

        public DateTimeOffset? IsDeleted { get; set; }

        public DateTimeOffset? UpdateDate { get; set; }
    }
}
