using FluentAPI.CodeGen.Models;

namespace FluentAPI.CodeGen.Models
{
    public partial class StudentDto
    {
        public int StudentId { get; }
        public string FirstName { get; }
        public string SurName { get; }
        public int CourseId { get; }
        public CourseDto Course { get; }
        public string Grade { get; }
        
        public StudentDto(int studentId, string firstName, string surName, int courseId, CourseDto course, string grade)
        {
            this.StudentId = studentId;
            this.FirstName = firstName;
            this.SurName = surName;
            this.CourseId = courseId;
            this.Course = course;
            this.Grade = grade;
        }
    }
}