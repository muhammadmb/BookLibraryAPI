using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Models.GenreModels
{
    public class GenreForAuthor
    {
        public Guid Id { get; set; }

        public string GenreName { get; set; }

        public string PicUrl { get; set; }
    }
}
