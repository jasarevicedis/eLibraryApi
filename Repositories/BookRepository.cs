using eLibraryApi.Data;
using eLibraryApi.Interfaces;
using eLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace eLibraryApi.Repository
{
    public class BookRepository: IBookRepository
    {
        private readonly DataContext _context;
        
        public BookRepository(DataContext context) {
            _context = context;
        }
        public async Task<List<Book>> GetBooks()
        {
            return await _context.books
                .Include(x=>x.Title)
                .Include(x=>x.Description)
                .Include(x=>x.copiesNumber)
                .ToListAsync();
        }

        public async Task<bool> AddBook(Book book)
        {
            await _context.AddAsync(book);
            return await Save();
        }

        public async Task<List<Book>> FilterAndOrderBooks(Category category, string SortOption)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.books
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Book>> GetBooksByName(string search)
        {
            return await _context.books
                .Where(a => a.Title.ToLower().Contains(search.ToLower()))
                .ToListAsync();
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public Task<bool> UpdateBook(Book book)
        {
            _context.Update(book);
            return Save();
        }
    }
}
