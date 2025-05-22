using ClothingManager.Application.Database.Entities;
using ClothingManager.Database.Abstractions.Interfaces;

namespace ClothingManager.Application.Database.Repositories.Interfaces
{
    public interface IEmployeesRepository : IDatabaseRepository<Employee>
    {
    }
}
