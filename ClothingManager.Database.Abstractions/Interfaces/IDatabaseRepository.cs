using ClothingManager.Database.Abstractions.Models;
using System.Linq.Expressions;

namespace ClothingManager.Database.Abstractions.Interfaces
{
    public interface IDatabaseRepository<TEntity>
        where TEntity : Entity
    {
        IEnumerable<TEntity>? Get(
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            string includeProperties = "");

        TEntity? GetById(Guid id);
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        void Delete(TEntity entity);
    }
}
