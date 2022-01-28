using FluentAPI.Domains;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Config
{
    public class MyRegister : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            // Generate Model
            config.AdaptTo("[name]Dto")
                .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "FluentAPI.Domains")
                .ExcludeTypes(typeof(SchoolContext))
                .ExcludeTypes(type => type.IsEnum);

            // Generate Extension Method
            config.GenerateMapper("[name]Mapper")
                    .ForType<Course>()
                    .ForType<Student>();
        }
    }
}
