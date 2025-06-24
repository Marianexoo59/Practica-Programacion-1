using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clases
{
    public class Empleado : Ejercicio1
    {
        public string Puesto { get; set; }

        public Empleado(string nombre, int edad, string puesto) : base(nombre, edad)
        {
            Puesto = puesto;
        }
    }
}
