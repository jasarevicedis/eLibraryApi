using eLibraryApi.Data;
using eLibraryApi.Interfaces;
using eLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace eLibraryApi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _dataContext;
        public BookRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> AddBook(Book book)
        {
            await _dataContext.authors.AddAsync(book.Author);

            //await _dataContext.AddAsync(book.Categories);
            if (book.Categories != null)
            {
                foreach (var category in book.Categories)
                {
                    await _dataContext.categories.AddAsync(category);
                }
            }
            if (book.BookInstances != null)
            {
                foreach (var instance in book.BookInstances)
                {
                    await _dataContext.bookinstances.AddAsync(instance);
                }
            }


            //await _dataContext.AddAsync(book.BookInstances);


            await _dataContext.AddAsync(book);

            return await Save();
        }

        public async Task<bool> BookExists(int id)
        {
            return await _dataContext.bookinstances.AnyAsync(a => a.Id == id);
        }

        public async Task<List<Book>> FilterAndOrderBooks(Category category, string SortOption)
        {
            var query = _dataContext.books.AsQueryable();
            //need to add filter by category  

            if (SortOption == "alphabetical")
                query = query.OrderBy(a => a.Title);

            //else if (SortOption == "popular")
                //query = query.OrderByDescending(a => a.Ratings.Select(r => r.Value).Average());

            return await query
                .Include(a => a.Author)
                .Include(a => a.Categories)
                .Include(a => a.BookInstances)
                .ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _dataContext.books
                .Where(a => a.Id == id)
                .Include(a => a.Author)
                .Include(a => a.Categories)
                .Include(a => a.BookInstances)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _dataContext.books
            .Include(a => a.Author)
            .Include(a => a.Categories)
            .Include(a => a.BookInstances)
            .ToListAsync();
        }

        public async Task<List<Book>> GetBooksByName(string name)
        {
            return await _dataContext.books
                .Where(a => a.Title.ToLower().Contains(name.ToLower()))
                .Include(a => a.Author)
                .Include(a => a.Categories)
                .Include(a => a.BookInstances)
                .ToListAsync();
        }

        public async Task<bool> Save()
        {
            var saved = await _dataContext.SaveChangesAsync();
            return saved > 0;
        }

        public Task<bool> UpdateBook(Book book)
        {
            _dataContext.Update(book);
            return Save();
        }
    }
}
