using System.Collections.Generic;
using FluentAPI.CodeGen.Models;
using FluentAPI.Domains;

namespace FluentAPI.CodeGen.Models
{
    public static partial class CourseMapper
    {
        public static CourseDto AdaptToDto(this Course p1)
        {
            return p1 == null ? null : new CourseDto()
            {
                Id = p1.Id,
                Students = funcMain1(p1.Students)
            };
        }
        public static CourseDto AdaptTo(this Course p3, CourseDto p4)
        {
            if (p3 == null)
            {
                return null;
            }
            CourseDto result = p4 ?? new CourseDto();
            
            result.Id = p3.Id;
            result.Students = funcMain2(p3.Students, result.Students);
            return result;
            
        }
        
        private static List<Person> funcMain1(List<Student> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<Person> result = new List<Person>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                Student item = p2[i];
                result.Add(item == null ? null : new Person()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
        
        private static List<Person> funcMain2(List<Student> p5, List<Person> p6)
        {
            if (p5 == null)
            {
                return null;
            }
            List<Person> result = new List<Person>(p5.Count);
            
            int i = 0;
            int len = p5.Count;
            
            while (i < len)
            {
                Student item = p5[i];
                result.Add(item == null ? null : new Person()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
    }
}