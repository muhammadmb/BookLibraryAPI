using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using System;
using System.Linq;

namespace BookLibraryApi.Helper
{
    public static class ReviewExtention
    {
        public static void handelRatting(this Review review, BookContext _context)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == review.BookId);
            var bookRate = _context.BookRatings.FirstOrDefault(r => r.BookId == book.Id);
            if(bookRate == null)
            {
                book.BookRating = new BookRating() { BookId = book.Id };
                _context.SaveChanges();
                _context.BookRatings.Add(book.BookRating);
                _context.SaveChanges();
            }

            switch (review.BookRate)
            {
                case 5:
                    bookRate.FiveStarsRate += 1;
                    bookRate.TotalRate += 5;
                    bookRate.ReviewsCount += 1;
                    break;
                case 4:
                    bookRate.FourStarsRate += 1;
                    bookRate.TotalRate += 4;
                    bookRate.ReviewsCount += 1;
                    break;
                case 3:
                    bookRate.ThreeStarsRate += 1;
                    bookRate.TotalRate += 3;
                    bookRate.ReviewsCount += 1;
                    break;
                case 2:
                    bookRate.TwoStarsRate += 1;
                    bookRate.TotalRate += 2;
                    bookRate.ReviewsCount += 1;
                    break;
                case 1:
                    bookRate.OneStarRate += 1;
                    bookRate.TotalRate += 1;
                    bookRate.ReviewsCount += 1;
                    break;
                default:
                    throw new AggregateException(nameof(review.BookRate));
            }
            _context.BookRatings.Update(bookRate);
            _context.SaveChanges();
        }
    }
}
