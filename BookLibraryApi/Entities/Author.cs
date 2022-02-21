using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class Author
    {
        public Author()
        {

        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Url]
        public string PictureUrl { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Bio { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfDeath { get; set; }

        public List<Book> Books { get; set; }

        public Guid GenreId { get; set; }

        public Genre Genre { get; set; }

        public DateTimeOffset AddedDate { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? IsDeleted { get; set; }

        public DateTimeOffset? UpdateDate { get; set; }
    }
}