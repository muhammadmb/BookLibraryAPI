using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.GenreModels
{
    public class GenreCreation
    {
        public string Description { get; set; }

        [Required]
        public string GenreName { get; set; }

        [Url]
        [Required]
        public string PicUrl { get; set; }
    }
}
