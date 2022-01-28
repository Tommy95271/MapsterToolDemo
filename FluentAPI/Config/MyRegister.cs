using FluentAPI.Domains;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Config
{
    public class MyRegister : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            // Generate Model
            config.AdaptTwoWays("[name]Dto")
                .ForType<Course>(cfg =>
                {
                    cfg.Ignore(poco => poco.IgnoredProp2);
                })
                .ForType<Student>(cfg =>
                {
                    cfg.Map(poco => poco.LastName, "SurName");
                    cfg.Map(poco => poco.Grade, typeof(string));
                })
                .ForType<Person>()
                .AlterType<Student, Person>()
                .MapToConstructor(true)
                .ExcludeTypes(typeof(SchoolContext))
                .ExcludeTypes(type => type.IsEnum)
                .IgnoreAttributes(typeof(DataMemberAttribute));


            // Generate Extension Method
            config.GenerateMapper("[name]Mapper")
                    .ForType<Course>()
                    .ForType<Student>();
        }
    }
}
