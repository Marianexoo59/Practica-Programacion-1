using System;

namespace Biblioteca_de_clases
{
    public class Prestamo
    {
        public Socio Socio { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public int DuracionDias { get; set; }

        public Prestamo(DateTime fechaPrestamo, Socio socio, int duracionDias)
        {
            FechaPrestamo = fechaPrestamo;
            Socio = socio;
            DuracionDias = duracionDias;
        }

        public void MostrarPrestamo()
        {
            Console.WriteLine($"Préstamo de {Socio.Nombre}, Fecha: {FechaPrestamo:dd/MM/yyyy}, Duración: {DuracionDias} días");
        }
    }
}
