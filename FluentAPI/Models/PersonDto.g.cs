namespace FluentAPI.CodeGen.Models
{
    public partial class PersonDto
    {
        public string FirstName { get; }
        public string LastName { get; }
        
        public PersonDto(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}