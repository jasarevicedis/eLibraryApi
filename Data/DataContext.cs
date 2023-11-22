using eLibraryApi.Models;
using Microsoft.EntityFrameworkCore;


namespace eLibraryApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<BookAuthor> books_authors { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Loan> loans { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<BookCategory> books_categories { get; set; }
        public DbSet<BookInstance> bookinstances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable(nameof(Book));
            modelBuilder.Entity<Author>().ToTable(nameof(Author));
            modelBuilder.Entity<BookAuthor>().ToTable(nameof(BookAuthor));
            modelBuilder.Entity<Category>().ToTable(nameof(Category));
            modelBuilder.Entity<Loan>().ToTable(nameof(Loan));
            modelBuilder.Entity<Student>().ToTable(nameof(Student));
            modelBuilder.Entity<BookCategory>().ToTable(nameof(BookCategory));
            modelBuilder.Entity<BookInstance>().ToTable(nameof(BookInstance));

            base.OnModelCreating(modelBuilder);
        }
    }
        
}
