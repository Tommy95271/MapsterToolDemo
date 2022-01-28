using FluentAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Domains
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [DataMember]
        public string IgnoredProp { get; set; }
        public Grade Grade { get; set; }
    }
}
