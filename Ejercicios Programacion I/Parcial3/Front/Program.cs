using Back.Repository;
using Parcial.Repository;

namespace Front
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1) Registrar Cliente");
                Console.WriteLine("2) Registrar Producto");
                Console.WriteLine("3) Registrar Venta");
                Console.WriteLine("4) Mostrar reportes de ventas por cliente");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese nombre del cliente: ");
                        var nombreCliente = Console.ReadLine();

                        var nuevoCliente = new Cliente
                        {
                            nombre = nombreCliente
                        };

                        ClienteRepository.RegistrarCliente(nuevoCliente);
                        Console.WriteLine($"Cliente registrado con ID: {nuevoCliente.id}");
                        break;

                    case "2":
                        Console.Write("Ingrese nombre del producto: ");
                        var nombreProducto = Console.ReadLine();

                        Console.Write("Ingrese precio del producto: ");
                        decimal.TryParse(Console.ReadLine(), out decimal precioProducto);

                        var nuevoProducto = new Producto
                        {
                            Nombre = nombreProducto,
                            Precio = precioProducto
                        };

                        ProductoRepository.RegistrarProducto(nuevoProducto);
                        Console.WriteLine($"Producto registrado con ID: {nuevoProducto.Id}");
                        break;

                    case "3":
                        Console.Write("Ingrese ID del cliente asociado: ");
                        int.TryParse(Console.ReadLine(), out int idClienteVenta);

                        Console.Write("Ingrese ID del producto asociado: ");
                        int.TryParse(Console.ReadLine(), out int idProductoVenta);

                        Console.Write("Ingrese cantidad vendida: ");
                        int.TryParse(Console.ReadLine(), out int cantidad);

                        var clienteExistente = ClienteRepository.ObtenerClientePorId(idClienteVenta);
                        var productoExistente = ProductoRepository.ObtenerProductoPorId(idProductoVenta);

                        if (clienteExistente == null)
                        {
                            Console.WriteLine("No se encontro un cliente con ese ID.");
                            break;
                        }

                        if (productoExistente == null)
                        {
                            Console.WriteLine("No se encontro un producto con ese ID.");
                            break;
                        }

                        VentaRepository.RegistrarVenta(clienteExistente, productoExistente, cantidad);
                        Console.WriteLine("Venta registrada correctamente.");
                        break;

                    case "4":
                        Console.Write("Ingrese ID del cliente para mostrar su reporte de ventas: ");
                        if (int.TryParse(Console.ReadLine(), out int idClienteReporte))
                        {
                            var clienteReporte = new Cliente { id = idClienteReporte };
                            ReporteRepository.MostrarReporteVentasPorCliente(clienteReporte);
                        }
                        else
                        {
                            Console.WriteLine("ID invalido.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

                Console.WriteLine("\nDesea realizar otra accion? (s/n)");
                var respuesta = Console.ReadLine();

                if (respuesta?.ToLower() != "s")
                {
                    continuar = false;
                    Console.WriteLine("Programa finalizado");
                }

                Console.WriteLine();
            }
        }
    }
}
