using eLibraryApi.Models;

namespace eLibraryApi.Dto
{
    public class CategoryDtoRequest
    {
        public string Name { get; set; }
        public CategoryDtoRequest()
        {
        }

        public CategoryDtoRequest(string name)
        {
            Name = name;
        }
    }
}
