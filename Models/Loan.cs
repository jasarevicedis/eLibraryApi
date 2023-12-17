namespace eLibraryApi.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public BookInstance BookInstance { get; set; }
        public Student Student { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Loan() { }
        public Loan(int id, BookInstance bookInstance, Student student, DateTime loanDate, DateTime dueDate, DateTime returnDate)
        {
            Id = id;
            BookInstance = bookInstance;
            Student = student;
            LoanDate = loanDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
        }
    }
}
