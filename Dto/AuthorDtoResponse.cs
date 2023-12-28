namespace eLibraryApi.Dto
{
    public class AuthorDtoResponse
    {
        public AuthorDtoResponse()
        {
        }

        public AuthorDtoResponse(string name,  string description)
        {
            Name = name;
            //AuthorImage = authorImage;
            Description = description;
        }

        public string Name { get; set; }
        //public string AuthorImage { get; set; }
        public string Description { get; set; }
    }
}
