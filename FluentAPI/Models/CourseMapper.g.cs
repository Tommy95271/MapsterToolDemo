using System.Collections.Generic;
using FluentAPI.CodeGen.Models;
using FluentAPI.Domains;
using FluentAPI.Enums;
using Mapster;
using Mapster.Utils;

namespace FluentAPI.CodeGen.Models
{
    public static partial class CourseMapper
    {
        private static TypeAdapterConfig TypeAdapterConfig1;
        
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
        
        private static List<StudentDto> funcMain1(List<Student> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<StudentDto> result = new List<StudentDto>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                Student item = p2[i];
                result.Add(item == null ? null : new StudentDto()
                {
                    StudentId = item.StudentId,
                    FirstName = item.FirstName,
                    SurName = item.LastName,
                    CourseId = item.CourseId,
                    Course = TypeAdapterConfig1.GetMapFunction<Course, CourseDto>().Invoke(item.Course),
                    Grade = Enum<Grade>.ToString(item.Grade)
                });
                i++;
            }
            return result;
            
        }
        
        private static List<StudentDto> funcMain2(List<Student> p5, List<StudentDto> p6)
        {
            if (p5 == null)
            {
                return null;
            }
            List<StudentDto> result = new List<StudentDto>(p5.Count);
            
            int i = 0;
            int len = p5.Count;
            
            while (i < len)
            {
                Student item = p5[i];
                result.Add(item == null ? null : new StudentDto()
                {
                    StudentId = item.StudentId,
                    FirstName = item.FirstName,
                    SurName = item.LastName,
                    CourseId = item.CourseId,
                    Course = TypeAdapterConfig1.GetMapFunction<Course, CourseDto>().Invoke(item.Course),
                    Grade = Enum<Grade>.ToString(item.Grade)
                });
                i++;
            }
            return result;
            
        }
    }
}