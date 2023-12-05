using eLibraryApi.Models;

namespace eLibraryApi.Interfaces
{
    public interface ILoanRepository
    {
        public Task<List<Loan>> GetLoans();
        public Task<Loan> GetLoanById(int id);
        public Task<List<Loan>> GetLoansByName(string name);
        public Task<List<Loan>> FilterAndOrderLoans(string SortOption);
        public Task<bool> AddLoan(Loan loan);
        public Task<bool> UpdateLoan(Loan loan);
        public Task<bool> Save();
    }
}
