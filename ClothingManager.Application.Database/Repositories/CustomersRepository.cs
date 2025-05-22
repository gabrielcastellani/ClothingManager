using ClothingManager.Application.Database.Context;
using ClothingManager.Application.Database.Entities;
using ClothingManager.Application.Database.Repositories.Interfaces;
using ClothingManager.Database.Repositories;

namespace ClothingManager.Application.Database.Repositories
{
    internal sealed class CustomersRepository : DatabaseRepository<Customer>, ICustomersRepository
    {
        public CustomersRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext) { }
    }
}
