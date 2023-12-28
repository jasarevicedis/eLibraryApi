using eLibraryApi.Models;

namespace eLibraryApi.Dto
{
    public class CategoryDtoRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryDtoRequest()
        {
        }

        public CategoryDtoRequest(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
