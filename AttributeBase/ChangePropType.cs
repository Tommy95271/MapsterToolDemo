using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeBase
{
    [AdaptTo("[name]Dto")]
    public class ChangePropType
    {
        public List<Person> People { get; set; }
    }

    [AdaptTo("[name]Dto"), PropertyType(typeof(Person2))]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [PropertyType(typeof(string))]
        public Gender? Gender { get; set; }
    }

    public class Person2
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum Gender
    {
        Female,
        Male
    }
}
