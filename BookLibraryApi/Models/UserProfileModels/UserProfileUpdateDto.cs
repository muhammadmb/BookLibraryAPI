using BookLibraryApi.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.UserProfileModels
{
    public class UserProfileUpdateDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        [Url]
        public string PictureUrl { get; set; }
    }
}
