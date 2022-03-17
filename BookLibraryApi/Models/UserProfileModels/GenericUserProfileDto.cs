using BookLibraryApi.Entities;
using System;

namespace BookLibraryApi.Models.UserProfileModels
{
    public class GenericUserProfileDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        public string PictureUrl { get; set; }
    }
}
