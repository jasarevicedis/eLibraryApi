using eLibraryApi.Models;

namespace eLibraryApi.Interfaces
{
    public interface IBookInstanceRepository
    {
        public Task<BookInstance> GetBookInstanceById(int id);
        public Task<List<BookInstance>> GetInstancesByBook(Book book);
        public Task<bool> BookInstanceExists(int id);
        public Task<bool> AddBookInstance(Book book);
        public Task<bool> Save();
    }
}
