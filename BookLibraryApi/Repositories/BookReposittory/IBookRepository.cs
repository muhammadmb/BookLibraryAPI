using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.BookReposittory
{
    public interface IBookRepository
    {
        Task<PagedList<Book>> GetBooks(Guid genreId, BookResourceParameters parameters);
        Task<Book> GetBook(Guid genreId, Guid bookId);
        void Create(Guid genreId, Book book);
        void Delete(Guid genreId, Guid bookId);
        void Update(Book book);
        Task<bool> SaveChangesAsync();
    }
}
