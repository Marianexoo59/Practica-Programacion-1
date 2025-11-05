using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Parcial.Data1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Ventas> venta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=Parcial3;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

    }
}
