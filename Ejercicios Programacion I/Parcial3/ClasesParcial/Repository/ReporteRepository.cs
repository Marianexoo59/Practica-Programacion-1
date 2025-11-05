using Parcial.Data1;
using System;
using System.Linq;

public class ReporteRepository
{
    public static void MostrarReporteVentasPorCliente(Cliente cliente)
    {
        using var context = new ApplicationDbContext();

        var ventas = context.venta
            .Where(v => v.ClienteId == cliente.id)
            .ToList();

        if (ventas.Count == 0)
        {
            Console.WriteLine("El cliente no tiene ventas registradas.");
            return;
        }

        Console.WriteLine("Ventas del cliente por producto:\n");

        foreach (var v in ventas)
        {
            Console.WriteLine($"Producto: {v.ProductoAsociado.Nombre} | Cantidad: {v.Cantidad} | Total: {v.ProductoAsociado.Precio * v.Cantidad}");
        }
    }
}
