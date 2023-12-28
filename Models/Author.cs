using System.Text.Json.Serialization;
using System.Text.Json;

namespace eLibraryApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        //public string AuthorImage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
        public Author() { }
        JsonSerializerOptions options = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            WriteIndented = true
        };
        public Author(int id,  string name, string description, List<Book> books)
        {
            Id = id;
            
            Name = name;
            Description = description;
            Books = books;
        }
    }
}
