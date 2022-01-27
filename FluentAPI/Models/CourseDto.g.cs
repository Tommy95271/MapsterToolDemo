using System.Collections.Generic;
using FluentAPI.MyModels;

namespace FluentAPI.MyModels
{
    public partial class CourseDto
    {
        public int Id { get; set; }
        public List<StudentDto> Students { get; set; }
    }
}