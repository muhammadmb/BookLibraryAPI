﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApi.Models.AuthorsModels
{
    public class GenericAuthorDto
    {
        [Required]
        public string Name { get; set; }

        [Url]
        public string PictureUrl { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Bio { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfDeath { get; set; }
    }
}
