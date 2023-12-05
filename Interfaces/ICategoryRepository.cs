using eLibraryApi.Models;

namespace eLibraryApi.Interfaces
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetCategories();
        public Task<Category> GetCategoryById(int id);
        public Task<bool> CategoryExists(int id);
        public Task<bool> AddCategory(Category category);
        public Task<bool> UpdateCategory(Category category);
        public Task<bool> Save();
    }
}
}
