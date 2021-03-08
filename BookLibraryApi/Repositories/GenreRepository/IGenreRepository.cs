using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.GenreRepository
{
    public interface IGenreRepository
    {
        Task<PagedList<Genre>> GetGenres(GenreResourcesParameters genreResourcesParameters);
        Task<Genre> GetGenre(Guid id);
        void CreateGenre(Genre genre);
        void UpdateGenre(Genre genre);
        Task<bool> SaveChangesAsync();
    }
}