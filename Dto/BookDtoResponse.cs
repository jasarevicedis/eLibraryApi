using eLibraryApi.Models;

namespace eLibraryApi.Dto
{
    public class BookDtoResponse
    {
        public string Title { get; set; }
        public string CoverImage { get; set; }

        public AuthorDtoResponse Author { get; set; }

    }
}
