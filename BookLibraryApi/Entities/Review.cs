using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string ReviewerName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(800)]
        public string ReviewDescription { get; set; }

        [Required]
        public int BookRate { get; set; }

        public Guid BookId { get; set; }

        public Book Book { get; set; }

        public int UpVote { get; set; }

        public int DownVote { get; set; }

        public DateTimeOffset AddedDate { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? IsDeleted { get; set; }

        public DateTimeOffset? UpdateDate { get; set; }
    }
}