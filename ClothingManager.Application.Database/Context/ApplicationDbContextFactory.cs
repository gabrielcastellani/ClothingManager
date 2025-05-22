using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClothingManager.Application.Database.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        ApplicationDbContext IDesignTimeDbContextFactory<ApplicationDbContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseNpgsql("User ID=postgres;Password=root;Host=localhost;Port=5432;Database=Recorders;Pooling=true;")
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
