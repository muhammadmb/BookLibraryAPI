using System;

namespace BookLibraryApi.Models.ReviewModels
{
    public class ReviewCreation : GenericReviewDto
    {
        public Guid BookId { get; set; }
    }
}
