using System.Collections.Generic;
using FluentAPI.CodeGen.Models;
using FluentAPI.Domains;
using FluentAPI.Enums;
using Mapster.Utils;

namespace FluentAPI.CodeGen.Models
{
    public static partial class StudentMapper
    {
        public static Student AdaptToStudent(this StudentDto p1)
        {
            return p1 == null ? null : new Student()
            {
                StudentId = p1.StudentId,
                FirstName = p1.FirstName,
                CourseId = p1.CourseId,
                Course = funcMain1(p1.Course),
                Grade = p1.Grade == null ? Grade.First : Enum<Grade>.Parse(p1.Grade)
            };
        }
        public static Student AdaptTo(this StudentDto p4, Student p5)
        {
            if (p4 == null)
            {
                return null;
            }
            Student result = p5 ?? new Student();
            
            result.StudentId = p4.StudentId;
            result.FirstName = p4.FirstName;
            result.CourseId = p4.CourseId;
            result.Course = funcMain3(p4.Course, result.Course);
            result.Grade = p4.Grade == null ? Grade.First : Enum<Grade>.Parse(p4.Grade);
            return result;
            
        }
        public static StudentDto AdaptToDto(this Student p10)
        {
            return p10 == null ? null : new StudentDto(p10.StudentId, p10.FirstName, p10.LastName, p10.CourseId, funcMain5(p10.Course), Enum<Grade>.ToString(p10.Grade));
        }
        public static StudentDto AdaptTo(this Student p13, StudentDto p14)
        {
            return p13 == null ? null : new StudentDto(p13.StudentId, p13.FirstName, p13.LastName, p13.CourseId, funcMain7(p13.Course), Enum<Grade>.ToString(p13.Grade));
        }
        
        private static Course funcMain1(CourseDto p2)
        {
            return p2 == null ? null : new Course()
            {
                Id = p2.Id,
                Students = funcMain2(p2.Students)
            };
        }
        
        private static Course funcMain3(CourseDto p6, Course p7)
        {
            if (p6 == null)
            {
                return null;
            }
            Course result = p7 ?? new Course();
            
            result.Id = p6.Id;
            result.Students = funcMain4(p6.Students, result.Students);
            return result;
            
        }
        
        private static CourseDto funcMain5(Course p11)
        {
            return p11 == null ? null : new CourseDto(p11.Id, funcMain6(p11.Students));
        }
        
        private static CourseDto funcMain7(Course p15)
        {
            return p15 == null ? null : new CourseDto(p15.Id, funcMain8(p15.Students));
        }
        
        private static List<Student> funcMain2(List<Person> p3)
        {
            if (p3 == null)
            {
                return null;
            }
            List<Student> result = new List<Student>(p3.Count);
            
            int i = 0;
            int len = p3.Count;
            
            while (i < len)
            {
                Person item = p3[i];
                result.Add(item == null ? null : new Student()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
        
        private static List<Student> funcMain4(List<Person> p8, List<Student> p9)
        {
            if (p8 == null)
            {
                return null;
            }
            List<Student> result = new List<Student>(p8.Count);
            
            int i = 0;
            int len = p8.Count;
            
            while (i < len)
            {
                Person item = p8[i];
                result.Add(item == null ? null : new Student()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
        
        private static List<Person> funcMain6(List<Student> p12)
        {
            if (p12 == null)
            {
                return null;
            }
            List<Person> result = new List<Person>(p12.Count);
            
            int i = 0;
            int len = p12.Count;
            
            while (i < len)
            {
                Student item = p12[i];
                result.Add(item == null ? null : new Person()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName
                });
                i++;
            }
            return result;
            
        }
        
        private static List<Person> funcMain8(List<Student> p16)
        {
            if (p16 == null)
            {
                return null;
            }
            List<Person> result = new List<Person>(p16.Count);
            
            int i = 0;
            int len = p16.Count;
            
            while (i < len)
            {
                Student item = p16[i];
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