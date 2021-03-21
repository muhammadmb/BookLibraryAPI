using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Models.BookModels
{
    public class BookForRatingDTO
    {
        public Guid Id { get; set; }

        public string BookTitle { get; set; }

        public string BookCover { get; set; }
    }
}
