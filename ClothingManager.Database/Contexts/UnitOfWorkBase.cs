using ClothingManager.Database.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClothingManager.Database.Contexts
{
    public abstract class UnitOfWorkBase : IUnitOfWorkBase
    {
        private bool _disposed = false;
        private readonly DbContext _dbContext;

        protected UnitOfWorkBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
