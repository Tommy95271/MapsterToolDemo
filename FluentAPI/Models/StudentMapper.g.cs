using System.Collections.Generic;
using FluentAPI.CodeGen.Models;
using FluentAPI.Domains;
using FluentAPI.Enums;
using Mapster.Utils;

namespace FluentAPI.CodeGen.Models
{
    public static partial class StudentMapper
    {
        public static StudentDto AdaptToDto(this Student p1)
        {
            return p1 == null ? null : new StudentDto()
            {
                StudentId = p1.StudentId,
                FirstName = p1.FirstName,
                SurName = p1.LastName,
                CourseId = p1.CourseId,
                Course = funcMain1(p1.Course),
                Grade = Enum<Grade>.ToString(p1.Grade)
            };
        }
        public static StudentDto AdaptTo(this Student p4, StudentDto p5)
        {
            if (p4 == null)
            {
                return null;
            }
            StudentDto result = p5 ?? new StudentDto();
            
            result.StudentId = p4.StudentId;
            result.FirstName = p4.FirstName;
            result.SurName = p4.LastName;
            result.CourseId = p4.CourseId;
            result.Course = funcMain3(p4.Course, result.Course);
            result.Grade = Enum<Grade>.ToString(p4.Grade);
            return result;
            
        }
        
        private static CourseDto funcMain1(Course p2)
        {
            return p2 == null ? null : new CourseDto()
            {
                Id = p2.Id,
                Students = funcMain2(p2.Students)
            };
        }
        
        private static CourseDto funcMain3(Course p6, CourseDto p7)
        {
            if (p6 == null)
            {
                return null;
            }
            CourseDto result = p7 ?? new CourseDto();
            
            result.Id = p6.Id;
            result.Students = funcMain4(p6.Students, result.Students);
            return result;
            
        }
        
        private static List<Person> funcMain2(List<Student> p3)
        {
            if (p3 == null)
            {
                return null;
            }
            List<Person> result = new List<Person>(p3.Count);
            
            int i = 0;
            int len = p3.Count;
            
            while (i < len)
            {
                Student item = p3[i];
                result.Add(item == null ? null : new Person()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
        
        private static List<Person> funcMain4(List<Student> p8, List<Person> p9)
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
    }
}