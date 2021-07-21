namespace Api.Domain.Entities
{
    public class AddressEntity : BaseEntity
    {
        public string Street { get; set; }
        public string neighborhood { get; set; } 
        public string city { get; set; }
        public string state { get; set; }
    }
}
