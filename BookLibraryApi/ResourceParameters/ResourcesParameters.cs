namespace BookLibraryApi.ResourceParameters
{
    public class ResourcesParameters
    {
        const int MaxPageSize = 16;

        public int PageNumber { get; set; } = 1;

        private int _PageSize = 12;

        public int PageSize
        {
            get => _PageSize;
            set => _PageSize = value > MaxPageSize ? MaxPageSize : value;
        }

        public string Fields { get; set; }

        public string SearchQuery { get; set; }
    }
}
