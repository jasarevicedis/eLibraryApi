namespace eLibraryApi.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public int BookInstanceId { get; set; }
        public int StudentId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
