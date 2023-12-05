using eLibraryApi.Models;

namespace eLibraryApi.Interfaces
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudents();
        public Task<Student> GetStudentById(int id);
        public Task<List<Student>> GetStudentsByName(string name);
        public Task<List<Student>> FilterAndOrderStudents(string SortOption);
        public Task<bool> StudentExists(int id);
        public Task<bool> AddStudent(Student student);
        public Task<bool> UpdateStudent(Student student);
        public Task<bool> Save();
    }
}
