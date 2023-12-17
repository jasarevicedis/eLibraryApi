namespace eLibraryApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        
        public List<Category> Categories { get; set; }
        public List<BookInstance> BookInstances { get; set; }
        public Author Author { get; set; }
        public int PublishYear { get; set; }
        public Book() { }
        public Book(int id, string title, string description, string coverImage, List<Category> categories, List<BookInstance> bookInstances, Author author, int publishYear)
        {
            Id = id;
            Title = title;
            Description = description;
            CoverImage = coverImage;
            Categories = categories;
            BookInstances = bookInstances;
            Author = author;
            PublishYear = publishYear;
        }
    }
}
