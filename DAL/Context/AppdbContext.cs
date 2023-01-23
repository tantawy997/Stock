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
    public DbSet<Catalogs> Catalogs { get; set; } = null!;

    //public DbSet<Photos> Photos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder ModelBuilder)
    {
        ModelBuilder.Entity<Products>().Property("name").HasMaxLength(50);
        ModelBuilder.Entity<Products>().Property("description").HasMaxLength(225);
        ModelBuilder.Entity<Products>().Property("type").HasMaxLength(100);



        //ModelBuilder.Entity<ProductDetails>().Property(a => a.Products).IsRequired();

        //ModelBuilder.Entity<Products>().HasOne(sp => sp.ProductDetails);
        //ModelBuilder.Entity<ProductDetails>().HasKey(a => a.)

        ModelBuilder.Entity<ProductDetails>().HasOne(a => a.Products).WithMany(e =>e.ProductDetails)
            .HasPrincipalKey(f => f.Id).HasForeignKey(a => a.Id);

        //ModelBuilder.Entity<Photos>().HasOne(a => a.products).WithMany(e => e.Photos)
        //    .HasPrincipalKey(f => f.Id).HasForeignKey(a => a.Id);
    }
}
