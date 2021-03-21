using System;

namespace BookLibraryApi.Models.RatingModels
{
    public class RatingDto
    {
        public Guid BookRateId { get; set; }

        public int FiveStarsRate { get; set; }

        public int FourStarsRate { get; set; }

        public int ThreeStarsRate { get; set; }

        public int TwoStarsRate { get; set; }

        public int OneStarRate { get; set; }

        public int TotalRate { get; set; }

        public int ReviewsCount { get; set; }

        public double BookRate { get; set; }

        public Guid BookId { get; set; }
    }
}
