using Microsoft.EntityFrameworkCore;

namespace Configuracion_de_EF
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=FinanzasDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
