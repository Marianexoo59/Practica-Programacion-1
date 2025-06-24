using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clases
{
    public class Persona
    {
        public string nombre {  get; set; }
        public int dni {  get; set; }

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
    }

    public class Estudiante : Persona
    {
        public int legajo {  get; set; }
        public string materia {  get; set; }
        public Estudiante(int legajo, string nombre, int dni) : base(nombre, dni)
        {
            this.legajo = legajo;
        }

        public string Estudiar(string materia )
        {
            this.materia = materia;
            return materia;
        }
    }

    public class Profesor : Persona
    {
        public string materia {  get; set; }

        public Profesor(string materia, string nombre, int dni) : base(nombre, dni)
        {
            this.materia = materia;
        }

        public string Enseñar(string materia)
        {
            this.materia = materia;
            return materia;
        }
    }
}
