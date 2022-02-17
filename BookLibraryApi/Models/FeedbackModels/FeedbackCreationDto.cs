using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.FeedbackModels
{
    public class FeedbackCreationDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
