using System.ComponentModel.DataAnnotations;

namespace eLibraryApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Grade { get; set; }
        public DateTime JoinDate { get; set; }
        public Student() { }

        public Student (int id, string firstName, string lastName, string email, string phone, int grade, DateTime joinDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Grade = grade;
            JoinDate = joinDate;
        }
    }
}
