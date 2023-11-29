namespace eLibraryApi.Dto
{
    public abstract class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public BookDto() { }
    }
}
