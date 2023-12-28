using System.Text.Json;
using System.Text.Json.Serialization;

namespace eLibraryApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Book> Books { get; set; }
        public Category()
        {
        }
        JsonSerializerOptions options = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            WriteIndented = true
        };
        public Category(int id, string name, List<Book> books)
        {
            Id = id;
            Name = name;
            Books = books;
        }
    }
}
