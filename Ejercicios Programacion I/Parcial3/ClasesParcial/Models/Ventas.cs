public class Ventas
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public Cliente ClienteAsociado { get; set; }
    public int ProductoId { get; set; }
    public Producto ProductoAsociado { get; set; }
    public int Cantidad { get; set; }

    public Ventas()
    {
        ClienteAsociado = new Cliente();
        ProductoAsociado = new Producto();
    }

    public Ventas(Cliente clienteasociado, Producto productoasociado, int cantidad)
    {
        ClienteAsociado = clienteasociado;
        ProductoAsociado = productoasociado;
        Cantidad = cantidad;
    }
}
