using ClothingManager.Application.Database.Entities;
using ClothingManager.Database.Abstractions.Interfaces;

namespace ClothingManager.Application.Database.Repositories.Interfaces
{
    public interface ICustomersRepository : IDatabaseRepository<Customer>
    { }
}
