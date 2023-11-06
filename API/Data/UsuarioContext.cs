using API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class UsuarioContext : IdentityDbContext<Usuario>{
        public UsuarioContext(DbContextOptions<UsuarioContext> opts) : base(opts) { }
    }
}