using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class Feedback
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.Now;

        [Required]
        public string Description { get; set; }

        public bool IsReaded { get; set; }

        public DateTimeOffset? IsDeleted { get; set; }

        public DateTimeOffset? UpdateDate { get; set; }
    }
}
