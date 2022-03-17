using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.AuthorsModels
{
    public class AuthorCreation : GenericAuthorDto
    {
        public Guid GenreId { get; set; }
    }
}
