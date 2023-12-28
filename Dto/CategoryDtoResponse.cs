namespace eLibraryApi.Dto
{
    public class CategoryDtoResponse
    {
        public CategoryDtoResponse()
        {
        }

        public CategoryDtoResponse(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
