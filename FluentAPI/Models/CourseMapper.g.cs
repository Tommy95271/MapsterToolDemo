using System.Collections.Generic;
using FluentAPI.CodeGen.Models;
using FluentAPI.Domains;

namespace FluentAPI.CodeGen.Models
{
    public static partial class CourseMapper
    {
        public static Course AdaptToCourse(this CourseDto p1)
        {
            return p1 == null ? null : new Course()
            {
                Id = p1.Id,
                Students = funcMain1(p1.Students)
            };
        }
        public static Course AdaptTo(this CourseDto p3, Course p4)
        {
            if (p3 == null)
            {
                return null;
            }
            Course result = p4 ?? new Course();
            
            result.Id = p3.Id;
            result.Students = funcMain2(p3.Students, result.Students);
            return result;
            
        }
        public static CourseDto AdaptToDto(this Course p7)
        {
            return p7 == null ? null : new CourseDto(p7.Id, funcMain3(p7.Students));
        }
        public static CourseDto AdaptTo(this Course p9, CourseDto p10)
        {
            return p9 == null ? null : new CourseDto(p9.Id, funcMain4(p9.Students));
        }
        
        private static List<Student> funcMain1(List<Person> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<Student> result = new List<Student>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                Person item = p2[i];
                result.Add(item == null ? null : new Student()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
        
        private static List<Student> funcMain2(List<Person> p5, List<Student> p6)
        {
            if (p5 == null)
            {
                return null;
            }
            List<Student> result = new List<Student>(p5.Count);
            
            int i = 0;
            int len = p5.Count;
            
            while (i < len)
            {
                Person item = p5[i];
                result.Add(item == null ? null : new Student()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
        
        private static List<Person> funcMain3(List<Student> p8)
        {
            if (p8 == null)
            {
                return null;
            }
            List<Person> result = new List<Person>(p8.Count);
            
            int i = 0;
            int len = p8.Count;
            
            while (i < len)
            {
                Student item = p8[i];
                result.Add(item == null ? null : new Person()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
        
        private static List<Person> funcMain4(List<Student> p11)
        {
            if (p11 == null)
            {
                return null;
            }
            List<Person> result = new List<Person>(p11.Count);
            
            int i = 0;
            int len = p11.Count;
            
            while (i < len)
            {
                Student item = p11[i];
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