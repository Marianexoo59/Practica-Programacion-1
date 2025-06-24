using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Alumno
    {
        public string Nombre { get; set; }

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }
    }

    public class Curso
    {
        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();

        public void AgregarAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }
    }
}
