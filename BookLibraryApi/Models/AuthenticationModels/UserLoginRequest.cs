﻿using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.AuthenticationModels
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
