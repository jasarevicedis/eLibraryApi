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
        public async Task<Book> GetBooks()
        {
            return await _context.books.ToListAsync();
        }

        
    }
}
