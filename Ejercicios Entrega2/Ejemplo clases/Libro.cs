using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clases
{
    public class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }

        public string libro {  get; set; }
        public Libro(string libro)
        {
            this.libro = libro;
        }
    }

    public class LibroDigital : Libro
    {
        public double pesoenmb {  get; set; }
        public string formato {  get; set; }
        public LibroDigital(string libro, double pesoenmb, string formato) : base(libro)
        {
            this.pesoenmb = pesoenmb;
            this.formato = formato;
        }
    }
}
