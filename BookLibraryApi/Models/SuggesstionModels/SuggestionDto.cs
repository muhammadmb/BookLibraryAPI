using BookLibraryApi.Models.AuthorsModels;
using BookLibraryApi.Models.GenreModels;
using System;

namespace BookLibraryApi.Models.SuggesstionModels
{
    public class SuggestionDto
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string BookTitle { get; set; }

        public string BookCover { get; set; }

        public DateTime DateOfPublish { get; set; }

        public int NumberOfBookPages { get; set; }

        public string Publisher { get; set; }

        public string Description { get; set; }

        public GenreForOtherEntitiesDto Genre { get; set; }

        public AuthorForBook Author { get; set; }

        public DateTimeOffset AddedDate { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? UpdateDate { get; set; } = null;
    }
}
