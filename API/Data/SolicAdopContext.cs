using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SolicAdopContext : DbContext{

        public SolicAdopContext(DbContextOptions<SolicAdopContext> opts) : base(opts){

        }

        public DbSet<SolicAdop> solics { get; set; }
        public DbSet<Animal> animais { get; set; }
        public DbSet<Especie> especies { get; set; }
        public DbSet<Raca> racas { get; set; }

    }
}