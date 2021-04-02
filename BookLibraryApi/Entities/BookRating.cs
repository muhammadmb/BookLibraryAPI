using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class BookRating
    {
        [Key]
        public Guid BookRateId { get; set; }

        public int FiveStarsRate { get; set; }

        public int FourStarsRate { get; set; }

        public int ThreeStarsRate { get; set; }

        public int TwoStarsRate { get; set; }

        public int OneStarRate { get; set; }

        public int TotalRate { get; set; }

        public int ReviewsCount { get; set; }

        public double BookRate
        {
            get => TotalRate > 1 ? (double)TotalRate / (double)ReviewsCount : 0;
        }

        public Guid BookId { get; set; }

        public Book Book { get; set; }

    }
}
