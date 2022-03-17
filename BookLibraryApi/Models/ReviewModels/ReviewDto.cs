using System;

namespace BookLibraryApi.Models.ReviewModels
{
    public class ReviewDto : GenericReviewDto
    {
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public int UpVote { get; set; }

        public int DownVote { get; set; }

        public DateTimeOffset AddedDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }
    }
}
