using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Departamento (int Id, string Nombre, string Descripcion)
        {
            this.Id = Id; 
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
        }

    }
}
