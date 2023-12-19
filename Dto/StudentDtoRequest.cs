namespace eLibraryApi.Dto
{
    public class StudentDtoRequest
    {
        public string ProfileImage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Grade { get; set; }
    }
}
