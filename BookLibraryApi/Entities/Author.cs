using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Url]
        public string PictureUrl { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Bio { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public DateTimeOffset DateOfDeath { get; set; }

        public List<Book> Books { get; set; }

        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }

        public bool IsDeleted { get; set; }
    }
}