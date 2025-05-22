using ClothingManager.Application.Database.Context;
using ClothingManager.Application.Database.Entities;
using ClothingManager.Application.Database.Repositories.Interfaces;
using ClothingManager.Database.Repositories;

namespace ClothingManager.Application.Database.Repositories
{
    internal sealed class EmployeesRepository : DatabaseRepository<Employee>, IEmployeesRepository
    {
        public EmployeesRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext) { }
    }
}
