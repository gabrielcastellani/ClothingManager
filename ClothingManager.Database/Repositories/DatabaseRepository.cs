using ClothingManager.Database.Abstractions.Interfaces;
using ClothingManager.Database.Abstractions.Models;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ClothingManager.Database.Repositories
{
    public abstract class DatabaseRepository<TEntity> : IDatabaseRepository<TEntity>
        where TEntity : Entity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public DatabaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity>? Get(
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public TEntity? GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Insert(TEntity entity)
        {
            if (entity.Id == Guid.Empty)
            {
                entity.Id = NewId.NextSequentialGuid();
            }

            _dbSet.Add(entity);
            return entity;
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            TEntity? entity = _dbSet.Find(id);

            if (entity is not null)
            {
                Delete(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }
    }
}
