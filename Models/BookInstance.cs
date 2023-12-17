namespace eLibraryApi.Models
{
    public class BookInstance
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public string InstanceId { get; set; }
        public bool isAvailable { get; set; }
        public BookInstance() { }

        public BookInstance(int id, Book book, string instanceId, bool isAvailable)
        {
            Id = id;
            Book = book;
            InstanceId = instanceId;
            this.isAvailable = isAvailable;
        }
    }
}
