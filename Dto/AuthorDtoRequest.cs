using eLibraryApi.Models;

namespace eLibraryApi.Dto
{
    public class AuthorDtoRequest
    {
        public string Name { get; set; }
        //public string AuthorImage { get; set; }
        public string Description { get; set; }
        public AuthorDtoRequest() { }

        public AuthorDtoRequest(string name, string description)
        {
            Name = name;
            //AuthorImage = authorImage;
            Description = description;
        }
    }
}
