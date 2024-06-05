using Gimnasio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gimnasio.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Suplemento> Suplementos { get; set; }

    }
}
