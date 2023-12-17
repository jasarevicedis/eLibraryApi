using eLibraryApi.Models;

namespace eLibraryApi.Dto
{
    public class BookDtoRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }

        public List<CategoryDtoRequest> Categories { get; set; }
        //public List<BookInstance> BookInstances { get; set; }
        public int InstancesNumber { get; set; }
        public AuthorDtoRequest Author { get; set; }
        public int PublishYear { get; set; }
        public BookDtoRequest() { }

        public BookDtoRequest(string title, string description, string coverImage, List<CategoryDtoRequest> categories, int instancesNumber, AuthorDtoRequest author, int publishYear)
        {
            Title = title;
            Description = description;
            CoverImage = coverImage;
            Categories = categories;
            InstancesNumber = instancesNumber;
            Author = author;
            PublishYear = publishYear;
        }
    }
}
