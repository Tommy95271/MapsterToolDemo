using System.Collections.Generic;
using FluentAPI.CodeGen.Models;

namespace FluentAPI.CodeGen.Models
{
    public partial class CourseDto
    {
        public int Id { get; set; }
        public List<StudentDto> Students { get; set; }
    }
}