using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Producto
    {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public Producto(int Id, string Nombre, decimal Precio)
    {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Precio = Precio;
    }
    public Producto()
    {
    }
}
