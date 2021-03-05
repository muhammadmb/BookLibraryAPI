using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Models
{
    public class GenreDto
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string GenreName { get; set; }
    }
}
