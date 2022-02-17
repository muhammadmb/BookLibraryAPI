namespace BookLibraryApi.Models.FeedbackModels
{
    public class FeedbackUpdateDto
    {
        public string Email { get; set; }

        public string Description { get; set; }

        public bool IsReaded { get; set; }

        public bool IsDeleted { get; set; }
    }
}
