﻿using BookLibraryApi.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryApi.Models.AuthenticationModels
{
    public class RefreshTokens
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public string JwtId { get; set; }
        public bool IsUsed { get; set; }
        public bool IsRevorked { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}
