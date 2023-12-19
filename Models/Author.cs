namespace eLibraryApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorImage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
        public Author() { }

        public Author(int id, string authorImage, string name, string description, List<Book> books)
        {
            Id = id;
            AuthorImage = authorImage;
            Name = name;
            Description = description;
            Books = books;
        }
    }
}
