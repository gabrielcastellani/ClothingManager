namespace ClothingManager.Database.Abstractions.Interfaces
{
    public interface IUnitOfWorkBase
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
