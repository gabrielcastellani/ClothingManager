using ClothingManager.Database.Abstractions.Models;

namespace ClothingManager.Application.Abstractions.Models
{
    public abstract record EmployeeAbstract : Entity
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public DateTime BirthDate { get; set; }

        public EmployeeAbstract() { }

        public EmployeeAbstract(EmployeeAbstract employee)
            : base(employee)
        {
            Name = employee.Name;
            Identifier = employee.Identifier;
            BirthDate = employee.BirthDate;
        }
    }
}
