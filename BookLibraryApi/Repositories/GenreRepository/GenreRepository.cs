﻿using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.GenreRepository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly BookContext _context;

        public GenreRepository(BookContext bookContext)
        {
            _context = bookContext ??
                throw new ArgumentNullException(nameof(bookContext));
        }

        public async Task<PagedList<Genre>> GetGenres(GenreResourcesParameters genreResourcesParameters)
        {
            if (genreResourcesParameters == null)
            {
                throw new ArgumentNullException(nameof(genreResourcesParameters));
            }

            var Collection =
                _context.Genres
                .Include(g => g.Books)
                .ThenInclude(b => b.Author)
                as IQueryable<Genre>;

            if (!string.IsNullOrWhiteSpace(genreResourcesParameters.SearchQuery))
            {
                genreResourcesParameters.SearchQuery = genreResourcesParameters.SearchQuery.Trim();

                Collection =
                    Collection.Where(
                        g =>
                            g.GenreName.Contains(genreResourcesParameters.SearchQuery) ||
                            g.Description.Contains(genreResourcesParameters.SearchQuery));
            }

            return PagedList<Genre>.Create(
                Collection,
                genreResourcesParameters.PageNumber,
                genreResourcesParameters.PageSize);
        }

        public async Task<Genre> GetGenre(Guid id)
        {
            return await 
                _context.Genres
                .Include(g => g.Books)
                .ThenInclude(b => b.Author)
                .FirstOrDefaultAsync(g => g.Id == id);
        }

        public void CreateGenre(Genre genre)
        {
            _context.Genres.Add(genre);
        }

        public void UpdateGenre(Genre genre)
        {
            _context.Genres.Update(genre);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }
    }
}
