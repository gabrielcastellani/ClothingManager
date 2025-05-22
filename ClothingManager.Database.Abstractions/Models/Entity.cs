namespace ClothingManager.Database.Abstractions.Models
{
    public abstract record Entity
    {
        public Guid Id { get; set; }

        public Entity(Entity entity)
        {
            Id = entity.Id;
        }
    }
}
