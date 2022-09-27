using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(){}
        public MySQLContext(DbContextOptions<MySQLContext>options):base(options){}
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name",
                Price = new decimal (69.9),
                Description = "alguma coisa descrita aqui",
                ImageUrl = "ainda nao tem",
                CategoryName="camisa"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "alguma coisa descrita aqui",
                ImageUrl = "ainda nao tem",
                CategoryName = "camisa"
            }); modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "alguma coisa descrita aqui",
                ImageUrl = "ainda nao tem",
                CategoryName = "camisa"
            }); modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "alguma coisa descrita aqui",
                ImageUrl = "ainda nao tem",
                CategoryName = "camisa"
            }); modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "alguma coisa descrita aqui",
                ImageUrl = "ainda nao tem",
                CategoryName = "camisa"
            }); modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "alguma coisa descrita aqui",
                ImageUrl = "ainda nao tem",
                CategoryName = "camisa"
            }); modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Name",
                Price = new decimal(69.9),
                Description = "alguma coisa descrita aqui",
                ImageUrl = "ainda nao tem",
                CategoryName = "camisa"
            });
        }

    }
}
