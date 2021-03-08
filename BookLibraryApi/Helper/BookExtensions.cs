using BookLibraryApi.Entities;
using System.Linq;

namespace BookLibraryApi.Helper
{
    public static class BookExtensions
    {
        public static int GetBookRate(this Book book)
        {
            var BookRate = 0;
            foreach (var bookReview in book.Reviews)
            {
                BookRate += bookReview.BookRate;
            }
            return BookRate / book.Reviews.Count();
        }
    }
}
