using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clases
{
    public class Producto
    {
        public string nombre {  get; set; }
        public double precio { get; set; }
        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }

    public class ProductoPerecedero : Producto
    {
        public ProductoPerecedero(string fechacaducidad, string nombre, double precio) : base(nombre,precio)
        {
            this.fechacaducidad = fechacaducidad;
        }

        public string fechacaducidad {  get; set; }
        public string EstadoVencido(string fechacaducidad)
        {
            this.fechacaducidad = fechacaducidad;
            return fechacaducidad;
        }
    }

    public class ProductoElectronico : Producto
    {
        public ProductoElectronico(double voltaje, string tienegarantia, string nombre, double precio) : base(nombre, precio)
        {
            this.voltaje = voltaje;
            this.tienegarantia = tienegarantia;
        }

        public double voltaje {  get; set; }
        public string tienegarantia {  get; set; }
    }
}
