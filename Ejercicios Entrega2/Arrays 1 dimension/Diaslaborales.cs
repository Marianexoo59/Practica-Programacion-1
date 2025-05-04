using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Array4
    {
        public static void Ejecutar()
        {
            string[] diasSemana = { "Domingo", "Miércoles", "Lunes", "Sábado", "Jueves", "Martes", "Viernes" };
            string[] diasLaborales = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

            foreach (string dia in diasSemana)
            {
                if (diasLaborales.Contains(dia))
                {
                    Console.WriteLine(dia);
                }
            }
        }
    }
}
