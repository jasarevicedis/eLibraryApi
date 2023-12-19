using eLibraryApi.Data;
using eLibraryApi.Interfaces;
using eLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace eLibraryApi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dataContext;
        public CategoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> AddCategory(Category category)
        {
            await _dataContext.AddAsync(category);

            return await Save();
        }

        public async Task<bool> CategoryExists(int id)
        {
            return await _dataContext.categories.AnyAsync(a => a.Id == id);
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _dataContext.categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _dataContext.categories
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<bool> Save()
        {
            var saved = await _dataContext.SaveChangesAsync();
            return saved > 0;
        }

        public Task<bool> UpdateCategory(Category category)
        {
            _dataContext.Update(category);
            return Save();
        }
    }
}
