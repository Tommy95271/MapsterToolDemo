using System.Collections.Generic;
using FluentAPI.Domains;

namespace FluentAPI.CodeGen.Models
{
    public partial class CourseDto
    {
        public int Id { get; }
        public List<Person> Students { get; }
        
        public CourseDto(int id, List<Person> students)
        {
            this.Id = id;
            this.Students = students;
        }
    }
}