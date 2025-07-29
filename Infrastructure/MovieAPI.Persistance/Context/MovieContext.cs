using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Domain.Entities.Concrete;
using MovieAPI.Persistance.Identity;

namespace MovieAPI.Persistance.Context
{
    public class MovieContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CAN-TOKHAY-MASA\\CANTOKHAY;initial Catalog=MovieBootcampDB;integrated Security=True;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-OHO9G30\\SQLEXPRESS;initial Catalog=MovieBootcampDB;integrated Security=True;TrustServerCertificate=True;");
        }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
