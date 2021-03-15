using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.ReviewModels
{
    public class ReviewCreation
    {
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
    }
}
