using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial.Data1;

namespace Parcial.Repository
{
    public static class ClienteRepository
    {
        public static void RegistrarCliente(Cliente Cliente)
        {
            using var context = new ApplicationDbContext();
            context.clientes.Add(Cliente);

            context.SaveChanges();
        }

        public static Cliente ObtenerClientePorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.clientes.FirstOrDefault(c => c.id == id);
        }

    }
}
