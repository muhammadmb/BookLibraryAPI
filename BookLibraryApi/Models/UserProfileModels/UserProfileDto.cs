﻿using BookLibraryApi.Entities;
using System;

namespace BookLibraryApi.Models.UserProfileModels
{
    public class UserProfileDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime AddedDate { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        public string PictureUrl { get; set; }

        public DateTimeOffset UpdateDate { get; set; }
    }
}
