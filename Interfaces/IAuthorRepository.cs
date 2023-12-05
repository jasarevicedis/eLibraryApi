using eLibraryApi.Models;

namespace eLibraryApi.Interfaces
{
    public interface IAuthorRepository
    {
        public Task<List<Author>> GetAuthors();
        public Task<Author> GetAuthorById(int id);
        public Task<List<Author>> GetAuthorsByName(string name);
        
        public Task<bool> AuthorExists(int id);
        public Task<bool> AddAuthor(Author author);
        public Task<bool> UpdateAuthor(Author author);
        public Task<bool> Save();
    }
}
