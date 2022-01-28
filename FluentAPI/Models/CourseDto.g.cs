using System.Collections.Generic;
using FluentAPI.Domains;

namespace FluentAPI.CodeGen.Models
{
    public partial class CourseDto
    {
        public int Id { get; set; }
        public List<Person> Students { get; set; }
    }
}