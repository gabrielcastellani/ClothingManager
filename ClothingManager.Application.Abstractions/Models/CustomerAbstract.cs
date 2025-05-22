using ClothingManager.Database.Abstractions.Models;

namespace ClothingManager.Application.Abstractions.Models
{
    public abstract record CustomerAbstract : Entity
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Initials { get; set; }

        public CustomerAbstract() { }

        public CustomerAbstract(CustomerAbstract customer)
            : base(customer)
        {
            Name = customer.Name;
            Initials = customer.Initials;
            Identifier = customer.Identifier;
        }
    }
}
