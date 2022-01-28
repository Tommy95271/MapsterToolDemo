using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Domains
{
    public class Course
    {
        public int Id { get; set; }
        public List<Student> Students { get; set; }
        public string IgnoredProp2 { get; set; }
    }
}
