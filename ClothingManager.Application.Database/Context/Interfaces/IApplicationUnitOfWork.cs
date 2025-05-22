using ClothingManager.Application.Database.Repositories.Interfaces;
using ClothingManager.Database.Abstractions.Interfaces;

namespace ClothingManager.Application.Database.Context.Interfaces
{
    public interface IApplicationUnitOfWork : IUnitOfWorkBase
    {
        ICustomersRepository CustomersRepository { get; }
        IEmployeesRepository EmployeesRepository { get; }
    }
}
