namespace BookLibraryApi.Models.FeedbackModels
{
    public class FeedbackUpdateDto : FeedbackCreationDto
    {
        public bool IsReaded { get; set; }
    }
}
