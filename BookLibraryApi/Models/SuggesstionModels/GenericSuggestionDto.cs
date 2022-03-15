using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.SuggesstionModels
{
    public class GenericSuggestionDto
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Url]
        public string BookCover { get; set; }

        public DateTime DateOfPublish { get; set; }

        public int NumberOfBookPages { get; set; }

        public string Publisher { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public Guid? AuthorId { get; set; }

        public Guid GenreId { get; set; }

        public DateTimeOffset AddedDate { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? UpdateDate { get; set; } = null;
    }
}
