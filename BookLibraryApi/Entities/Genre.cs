using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }

        public string Description { get; set; }

        [Required]
        public string GenreName { get; set; }

        [Url]
        [Required]
        public string PicUrl { get; set; }

        public List<Book> Books { get; set; }

        public List<Author> Authors { get; set; }

        public DateTimeOffset AddedDate { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? IsDeleted { get; set; }

        public DateTimeOffset? UpdateDate { get; set; }
    }
}