    using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Stock.Models;

namespace Stock.Context;

public class AppdbContext : DbContext
{
    public AppdbContext(DbContextOptions<AppdbContext> options) :base(options)
    {

    }

    public DbSet<Products> Products { get; set; } = null!;

    public DbSet<ProductDetails> ProductDetails { get; set; } = null!;
    public DbSet<Catalog> Catalogs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder ModelBuilder)
    {
        ModelBuilder.Entity<Products>().Property("name").HasMaxLength(50);
        ModelBuilder.Entity<Products>().Property("description").HasMaxLength(225);
        ModelBuilder.Entity<Products>().Property("type").HasMaxLength(100);

        ModelBuilder.Entity<Products>().HasData(
            new Products { Id = Guid.NewGuid(), name = "Cold" },
            new Products { Id = Guid.NewGuid(), name = "Stress" },
            new Products { Id = Guid.NewGuid(), name = "Headache" }
            );


        #region Seeding Patients
            ModelBuilder.Entity<Catalog>().HasData(
            new Catalog { Id = Guid.NewGuid(), Name = "John" },
            new Catalog { Id = Guid.NewGuid(), Name = "James" },
            new Catalog { Id = Guid.NewGuid(), Name = "Anderson" }
            );

        #endregion
    }
}
