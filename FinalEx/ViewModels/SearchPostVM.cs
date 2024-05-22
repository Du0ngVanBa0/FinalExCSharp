namespace FinalEx.ViewModels
{
    public class SearchPostVM
    {
        public string? SearchText { get; set; }

        public int? CategoryId { get; set; }

        public string? AuthorName { get; set; }

        public DateTime? PostedDateFrom { get; set; }

        public DateTime? PostedDateTo { get; set; }
    }
}
