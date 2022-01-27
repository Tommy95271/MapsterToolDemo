namespace MapsterToolDemo.AttributeBase
{
    public partial class ReadonlyPropDto
    {
        public int Id { get; }
        
        public ReadonlyPropDto(int id)
        {
            this.Id = id;
        }
    }
}