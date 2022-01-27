using FluentAPI.MyModels;

namespace FluentAPI.MyModels
{
    public partial class StudentDto
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
    }
}