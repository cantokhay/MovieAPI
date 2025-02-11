using Microsoft.EntityFrameworkCore;
using MovieAPI.Domain.Entities.Concrete;

namespace MovieAPI.Persistance.Context
{
    public class MovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CAN-TOKHAY-MASA\\CANTOKHAY;initial Catalog=MovieBootcampDB;integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
