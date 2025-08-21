using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    internal class Viajes
    {
        public int Distancia { get; set; }
        public int CargaTransportada { get; set; }
        public DateTime Fecha { get; set; }

        public List<Viajes> NuevoViaje = new List<Viajes>();
    }
}
