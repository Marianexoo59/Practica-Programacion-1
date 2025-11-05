using Parcial.Data1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Repository
{
    public class ProductoRepository
    {
        public static void RegistrarProducto(Producto Producto)
        {
            using var context = new ApplicationDbContext();
            context.productos.Add(Producto);

            context.SaveChanges();
        }

        public static Producto ObtenerProductoPorId(int id)
        {
            using var context = new ApplicationDbContext();
            return context.productos.FirstOrDefault(p => p.Id == id);
        }

    }
}
