using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.GenreModels
{
    public class GenreUpdate
    {
        public string Description { get; set; }

        [Required]
        public string GenreName { get; set; }

        [Url]
        [Required]
        public string PicUrl { get; set; }

        public bool IsDeleted { get; set; }
    }
}
