using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Viajes
    {
        public int Distancia { get; set; }
        public int CargaTransportada { get; set; }
        public DateTime Fecha { get; set; }

        public Viajes(int Distancia, int CargaTransportada, DateTime Fecha)
        {
            this.Distancia = Distancia;
            this.CargaTransportada = CargaTransportada;
            this.Fecha = Fecha;
        }

    }
}
