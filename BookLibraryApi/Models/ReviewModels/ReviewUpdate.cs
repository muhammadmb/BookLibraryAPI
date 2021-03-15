using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.ReviewModels
{
    public class ReviewUpdate
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
        public int UpVote { get; set; }

        public int DownVote { get; set; }
    }
}
