using ClasesEjercicioPrueba.Models1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClasesEjercicioPrueba.Data
{
    internal class AplicationDBContext
    {
        public DbSet<Vehiculo> Vehiculo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=FinanzasDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

    }
}
