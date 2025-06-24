using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public abstract class Empleado
    {
        public int valorhora { get; set; }
        public int cantidadhoras { get; set; }
        public int sueldo { get; set; }

        public Empleado(int valorhora, int cantidadhoras)
        {
            this.valorhora = valorhora;
            this.cantidadhoras = cantidadhoras;
        }
    }

    public class EmpleadoPermanente : Empleado
    {
        public EmpleadoPermanente(int valorhora, int cantidadhoras) : base(valorhora, cantidadhoras)
        {
            sueldo = valorhora * cantidadhoras;
        }
    }

    public class EmpleadoTemporal : Empleado
    {
        public EmpleadoTemporal(int valorhora, int cantidadhoras) : base(valorhora, cantidadhoras)
        {
            sueldo = (valorhora * cantidadhoras) * 2;
        }
    }
}
