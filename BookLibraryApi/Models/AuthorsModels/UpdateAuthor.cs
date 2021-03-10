using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.AuthorsModels
{
    public class UpdateAuthor
    {
        [Required]
        public string Name { get; set; }

        [Url]
        public string PictureUrl { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Bio { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public DateTimeOffset DateOfDeath { get; set; }

        public Guid GenreId { get; set; }
    }
}
