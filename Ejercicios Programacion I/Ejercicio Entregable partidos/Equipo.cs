using ClasesApp;

namespace ClasesApp
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }

        public int Puntos { get; set; }
        public int GolesAFavor { get; set; }
        public int GolesEnContra { get; set; }

        public int DiferenciaGoles
        {
            get { return GolesAFavor - GolesEnContra; }
        }

        public Equipo(string Nombre, string Ciudad)
        {
            this.Nombre = Nombre;
            this.Ciudad = Ciudad;
            Puntos = 0;
            GolesAFavor = 0;
            GolesEnContra = 0;
        }

        public void RegistrarResultado(Equipo local, Equipo visitante, int golesLocal, int golesVisitante)
        {
            local.GolesAFavor += golesLocal;
            local.GolesEnContra += golesVisitante;

            visitante.GolesAFavor += golesVisitante;
            visitante.GolesEnContra += golesLocal;

            if (golesLocal > golesVisitante)
                local.Puntos += 3;
            else if (golesLocal < golesVisitante)
                visitante.Puntos += 3;
            else
            {
                local.Puntos += 1;
                visitante.Puntos += 1;
            }
        }
    }
    public class AdministradorTorneo : Partidos
    {
        List<Equipo> equipos = new List<Equipo>();

        public void AgregarEquipo(string Nombre, string Ciudad)
        {
            equipos.Add(new Equipo(Nombre, Ciudad));
        }

        public List<Equipo> ObtenerEquipos()
        {
            return equipos;
        }

        public bool HayEquipos()
        {
            return equipos.Any();
        }

        public void JugarPartido(Equipo local, Equipo visitante, int golesLocal, int golesVisitante)
        {
            local.GolesAFavor += golesLocal;
            local.GolesEnContra += golesVisitante;

            visitante.GolesAFavor += golesVisitante;
            visitante.GolesEnContra += golesLocal;

            if (golesLocal > golesVisitante)
                local.Puntos += 3;
            else if (golesLocal < golesVisitante)
                visitante.Puntos += 3;
            else
            {
                local.Puntos += 1;
                visitante.Puntos += 1;
            }

            historialPartidos.Add(new Partidos
            {
                Local = local,
                Visitante = visitante,
                GolesLocal = golesLocal,
                GolesVisitante = golesVisitante,
                Fecha = DateTime.Now
            });
        }

        List<Partidos> historialPartidos = new List<Partidos>();

        public List<Partidos> ObtenerHistorial()
        {
            return historialPartidos;
        }
    }
}

