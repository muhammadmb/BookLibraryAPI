﻿using System;

namespace BookLibraryApi.Models.ReviewModels
{
    public class ReviewForBook
    {
        public Guid Id { get; set; }

        public string ReviewerName { get; set; }

        public string Email { get; set; }

        public string ReviewDescription { get; set; }

        public int BookRate { get; set; }

        public Guid BookId { get; set; }

        public int UpVote { get; set; }

        public int DownVote { get; set; }
    }
}
