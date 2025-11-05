using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial.Data1;

public class VentaRepository
{
    public static void RegistrarVenta(Cliente clienteasociado, Producto productoasociado, int cantidad)
    {
        using var context = new ApplicationDbContext();
        // Adjunta las entidades existentes para que EF no intente volver a insertarlas
        context.Attach(clienteasociado);
        context.Attach(productoasociado);

        var venta = new Ventas(clienteasociado, productoasociado, cantidad)
        {
            ClienteId = clienteasociado.id,
            ProductoId = productoasociado.Id
        };

        context.venta.Add(venta);
        context.SaveChanges();
    }
}
