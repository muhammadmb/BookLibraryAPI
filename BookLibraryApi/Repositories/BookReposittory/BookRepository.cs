using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.BookReposittory
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<PagedList<Book>> GetBooks(Guid genreId, BookResourceParameters parameters)
        {
            var Collection =
                _context.Books.Where(b => b.GenreId == genreId)
                .Include(b => b.Author)
                .Include(b => b.Reviews)
                .Include(b => b.Genre)
                as IQueryable<Book>;

            if(parameters.YearOfPublish != null)
            {
                Collection =
                    _context.Books
                    .Where(b => b.DateOfPublish.Year.ToString().Equals(parameters.YearOfPublish))
                    .Include(b => b.Author)
                    .Include(b => b.Reviews)
                    .Include(b => b.Genre);
            }

            if (!string.IsNullOrWhiteSpace(parameters.Author))
            {
                parameters.Author = parameters.Author.Trim();

                Collection =
                    _context.Books
                    .Where(b => b.Author.Name == parameters.Author)
                    .Include(b => b.Author)
                    .Include(b => b.Reviews)
                    .Include(b => b.Genre);
            }

            if (!string.IsNullOrWhiteSpace(parameters.SortBy))
            {
                parameters.SortBy = parameters.SortBy.Trim();

                if (parameters.SortBy.ToLowerInvariant() == "title")
                {
                    Collection =
                        Collection.OrderBy(b => b.BookTitle);
                }
                if (parameters.SortBy.ToLowerInvariant() == "popularity")
                {
                    Collection =
                        Collection.OrderBy(b => b.Reviews.Count());
                }
                if (parameters.SortBy.ToLowerInvariant() == "date")
                {
                    Collection =
                        Collection.OrderByDescending(b => b.DateOfPublish);
                }
            }

            return PagedList<Book>.Create(
                Collection,
                parameters.PageNumber,
                parameters.PageSize);
        }

        public async Task<Book> GetBook(Guid genreId, Guid bookId)
        {
            return await _context.Books
                .Include(b => b.Reviews)
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(b => b.GenreId == genreId && b.Id == bookId);
        }

        public void Create(Guid genreId, Book book)
        {
            book.GenreId = genreId;
            _context.Books.Add(book);
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }
    }
}
