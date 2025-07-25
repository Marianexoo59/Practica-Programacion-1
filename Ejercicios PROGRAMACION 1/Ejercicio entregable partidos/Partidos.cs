using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesApp
{
    public class Partidos
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()} - {Local.Nombre} {GolesLocal} : {GolesVisitante} {Visitante.Nombre}";
        }
    }
}
