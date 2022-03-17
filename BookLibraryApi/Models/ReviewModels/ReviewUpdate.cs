namespace BookLibraryApi.Models.ReviewModels
{
    public class ReviewUpdate : GenericReviewDto
    {
        public int UpVote { get; set; }

        public int DownVote { get; set; }
    }
}
