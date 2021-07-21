using System;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name {get; set;}
        public string Cpf {get; set;}
        public string Email {get; set;}
        public DateTime BirthDate {get; set;} 
        public AddressEntity adress { get; set;}
    }
}
