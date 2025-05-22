using ClothingManager.Application.Database.Context.Interfaces;
using ClothingManager.Application.Database.Repositories.Interfaces;
using ClothingManager.Database.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClothingManager.Application.Database.Context
{
    internal sealed class ApplicationUnitOfWork : UnitOfWorkBase, IApplicationUnitOfWork
    {
        public ICustomersRepository CustomersRepository { get; private set; }
        public IEmployeesRepository EmployeesRepository { get; private set; }

        public ApplicationUnitOfWork(
            DbContext dbContext,
            ICustomersRepository customersRepository,
            IEmployeesRepository employeesRepository)
            : base(dbContext)
        {
            CustomersRepository = customersRepository;
            EmployeesRepository = employeesRepository;
        }
    }
}
