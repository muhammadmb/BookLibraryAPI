using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Models.AuthorsModels
{
    public class AuthorForBook
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
