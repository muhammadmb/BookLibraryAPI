﻿using BookLibraryApi.Contexts;
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
            IQueryable<Book> Collection;

            if (genreId != Guid.Empty)
            {
                Collection =
                    _context.Books.Where(b => b.GenreId == genreId)
                    .Include(b => b.Author)
                    .Include(b => b.Reviews)
                    .Include(b => b.Genre)
                    .Include(b => b.BookRating);
            }
            else
            {
                Collection =
                    _context.Books
                    .Include(b => b.Author)
                    .Include(b => b.Reviews)
                    .Include(b => b.Genre)
                    .Include(b => b.BookRating);
            }


            if (parameters.YearOfPublish != null)
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
                    .Include(b => b.Genre)
                    .Include(b => b.BookRating)
                    ;
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
                if (parameters.SortBy.ToLowerInvariant() == "rating")
                {
                    Collection =
                        Collection.OrderBy(b => b.BookRating);
                }
            }

            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
            {
                parameters.SearchQuery = parameters.SearchQuery.Trim();

                Collection =
                    Collection.Where(b =>
                    b.BookTitle.Contains(parameters.SearchQuery) ||
                    b.Description.Contains(parameters.SearchQuery) ||
                    b.Publisher.Contains(parameters.SearchQuery));
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
                .Include(b => b.BookRating)
                .FirstOrDefaultAsync(b => b.GenreId == genreId && b.Id == bookId);
        }

        public void Create(Guid genreId, Book book)
        {
            book.GenreId = genreId;
            book.BookRating = new BookRating() { BookId = book.Id };
            _context.Books.Add(book);
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
        }
        public void Delete(Guid genreId, Guid bookId)
        {
            var book = new Book()
            {
                GenreId = genreId,
                Id = bookId
            };
            _context.Books.Remove(book);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

    }
}
