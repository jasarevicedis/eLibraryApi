namespace eLibraryApi.Models
{
    public class BookInstance
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public bool isAvailable { get; set; }

    }
}
