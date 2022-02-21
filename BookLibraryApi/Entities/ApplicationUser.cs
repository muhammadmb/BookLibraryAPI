using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTimeOffset AddedDate { get; set; } = DateTime.Now;

        public string Country { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        [Url]
        public string PictureUrl { get; set; }

        public DateTimeOffset? IsDeleted { get; set; }

        public DateTimeOffset? UpdateDate { get; set; }

    }

    public enum Gender { Male, Female };
}
