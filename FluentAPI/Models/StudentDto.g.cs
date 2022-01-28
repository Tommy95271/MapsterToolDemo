using FluentAPI.CodeGen.Models;

namespace FluentAPI.CodeGen.Models
{
    public partial class StudentDto
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
        public string Grade { get; set; }
    }
}