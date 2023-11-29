using eLibraryApi.Models;

namespace eLibraryApi.Interfaces
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetBooks();
        public Task<Book> GetBookById(int id);
        public Task<List<Book>> GetBooksByName(string name);
        public Task<List<Book>> FilterAndOrderBooks(Category category, string SortOption);
        public Task<bool> BookExists(int id);
        public Task<bool> AddBook(Book book);
        public Task<bool> UpdateBook(Book book);
        public Task<bool> Save();
    }
}
