using System;

namespace BookLibraryApi.Models.UserProfileModels
{
    public class UserProfileDto : GenericUserProfileDto
    {
        public Guid Id { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }
    }
}
