using System;

namespace BookLibraryApi.Models.GenreModels
{
    public class GenreForOtherEntitiesDto
    {
        public Guid Id { get; set; }

        public string GenreName { get; set; }

        public string PicUrl { get; set; }
    }
}
