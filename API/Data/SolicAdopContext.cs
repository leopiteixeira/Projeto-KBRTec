using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SolicAdopContext : DbContext{

        public SolicAdopContext(DbContextOptions<SolicAdopContext> opts) : base(opts){

        }

        public DbSet<SolicAdop> solics { get; set; }

    }
}