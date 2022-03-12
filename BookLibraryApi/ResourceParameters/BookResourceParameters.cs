using System;

namespace BookLibraryApi.ResourceParameters
{
    public class BookResourceParameters : ResourcesParameters
    {
        public string SortBy { get; set; }

        public Guid Author { get; set; }

        public string YearOfPublish { get; set; }
    }
}
