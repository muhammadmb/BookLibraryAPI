using System;

namespace BookLibraryApi.Models.GenreModels
{
    public class GenreDto
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string GenreName { get; set; }

        public string PicUrl { get; set; }

        public DateTimeOffset AddedDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

    }
}
